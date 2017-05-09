using System.Collections.Generic;
using SharpnYNAB.Schema;
using System.Net;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

// ReSharper disable InconsistentNaming

namespace SharpnYNAB
{
    public interface IConnection
    {
        Task init_session();
        Task<string> Dorequest(Dictionary<string, object> request_dict, string opname);
        string UserId { get; set; }
    }

    public partial class Connection : IConnection
    {
        private Uri urlCatalog = new Uri("https://app.youneedabudget.com");
        private string baseCatalog = "/api/v1/catalog";
        private string SessionToken { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public string Id { get; set; } = Utils.GenerateUuid();
        public CookieContainer Cookies { get; private set; }

        public Connection(string email, string password)
        {
            Email = email;
            Password = password;

        }

        class UserData
        {
            public string id { get; set; }
        }

        class FirstLoginResponse
        {
            public string session_token { get; set; }
            public UserData userdata { get; set; }
        }

        public async Task init_session()
        {
            Cookies = new CookieContainer();
            var FirstLogin = await Dorequest(new Dictionary<string, object>
            {
                ["email"] = Email,
                ["password"] = Password,
                ["remember_me"] = true,
                ["device_info"] = new Dictionary<string, object>
                {
                    ["id"] = Id
                }
            }, "loginUser");
            var firstlogin = JsonConvert.DeserializeObject<FirstLoginResponse>(FirstLogin);
            SessionToken = firstlogin.session_token;
            UserId = firstlogin.userdata?.id;
        }

        /*  self.session.cookies = RequestsCookieJar()

                              self.session.headers['X-YNAB-Device-Id'] = self.id
                              self.session.headers['User-Agent'] = 'python nYNAB API bot - rienafairefr rienafairefr@gmail.com'

                              firstlogin = self.dorequest({
                                  "email": self.email, "password": self.password, "remember_me": True,
                                                           "device_info": { "id": self.id}
                              }, 'loginUser')
                              if firstlogin is None:
                                  raise NYnabConnectionError('Couldnt connect with the provided email and password')
                              self.SessionToken = firstlogin["session_token"]
                              self.session.headers['X-Session-Token'] = self.SessionToken
                              self.user_id = firstlogin['user']['id']

                          def __init__(self, email, password):
                              self.email = email
                              self.password = password
                              self.session = requests.Session()
                              self.SessionToken = None
                              self.id = str(generateuuid())
                              self.lastrequest_elapsed = None*/
        public enum YnabError
        {
            user_not_found, user_password_invalid, request_throttled
        }

        public class ResponseUser
        {
            public string id;
        }

        public async Task<string> Dorequest(Dictionary<string, object> request_dict, string opname)
        {
            var json_request_dict = Newtonsoft.Json.JsonConvert.SerializeObject(request_dict);
            using (var handler = new HttpClientHandler()
            {
                CookieContainer = Cookies,
                UseCookies = true
            })
            using (var client = new HttpClient(handler)
            {
                BaseAddress = urlCatalog,
            })
            {
                var requestmessage = new HttpRequestMessage(HttpMethod.Post, baseCatalog);
                requestmessage.Headers.Add("User-Agent", "C# client for YNAB rienafairefr");
                requestmessage.Headers.Add("X-YNAB-Device-Id", Id);
                if (SessionToken != null)
                {
                    requestmessage.Headers.Add("X-Session-Token", SessionToken);
                }
                requestmessage.Content = new FormUrlEncodedContent(new Dictionary<string, string>
                {
                    ["operation_name"] = opname,
                    ["request_data"] = json_request_dict,
                });


                var response = await client.SendAsync(requestmessage);
                switch (response.StatusCode)
                {
                    case HttpStatusCode.InternalServerError:
                        break;
                    case HttpStatusCode.OK:
                        var responsecontent = await response.Content.ReadAsStringAsync();
                        var js = Newtonsoft.Json.JsonConvert.DeserializeObject<YnabResponse>(responsecontent);
                        switch (js.error)
                        {
                            case null:
                                return responsecontent;
                            case YnabError.user_not_found:
                                break;
                            case YnabError.user_password_invalid:
                                break;
                            case YnabError.request_throttled:
                                var retryrafter = response.Headers.RetryAfter.Delta?.Milliseconds;
                                if (retryrafter != null)
                                {
                                    await Task.Delay((int)retryrafter);
                                    return Dorequest(request_dict, opname).Result;
                                }
                                break;
                            default:
                                throw new ArgumentOutOfRangeException();
                        }
                        break;
                }
            }


            return null;
            /*params = {
                    u'operation_name': opname, 'request_data': json_request_dict
                LOG.debug(('%s  ... %s ' % (opname, params)).replace(self.password, '********'))
            r = self.session.post(self.urlCatalog, params)
            self.lastrequest_elapsed = r.elapsed
            js = r.json()
            if r.status_code == 500:
                raise NYnabConnectionError('Uunrecoverable server error, sorry YNAB')
            if r.status_code != 200:
                LOG.debug('non-200 HTTP code: %s ' % r.text)
            if not 'error' in js:
                errorout('The server returned a json value without an error field')
            if js['error'] is None:
                return js
            error = js['error']
            if 'id' not in error:
                errorout('Error field %s without id returned from the API, %s' % (error, params))
            if error['id'] == 'user_not_found':
                errorout('API error, User Not Found')
            elif error['id'] == 'user_password_invalid':
                errorout('API error, User-Password combination invalid')
            elif error['id'] == 'request_throttled':
                LOG.debug('API Rrequest throttled')
                retryrafter = r.headers['Retry-After']
                LOG.debug('Waiting for %s s' % retryrafter)
                sleep(float(retryrafter))
                return self.dorequest(request_dic, opname)
            else:
                errorout('Unknown API Error \"%s\" was returned from the API when sending request (%s)' % (error['id'], params))
                */
        }

        public string UserId { get; set; }
    }


}