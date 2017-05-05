using System.Collections.Generic;
using SharpnYNAB.Schema;

namespace SharpnYNAB
{
    public class Connection
    {
        private const string urlCatalog = "https://app.youneedabudget.com/api/v1/catalog";

        public string Email { get; set; }
        public string Password { get; set; }
        public string Id { get; set; } = Utils.GenerateUuid();

        public Connection(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public void init_session()
        {
            var FirstLogin = Dorequest(new Dictionary<string, object>
            {
                ["email"] = Email,
                ["password"] = Password,
                ["remember_me"] = true,
                ["device_info"] = new Dictionary<string, object>
                {
                    ["id"] = Id
                }
            }, "loginUser");
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
                              self.sessionToken = firstlogin["session_token"]
                              self.session.headers['X-Session-Token'] = self.sessionToken
                              self.user_id = firstlogin['user']['id']

                          def __init__(self, email, password):
                              self.email = email
                              self.password = password
                              self.session = requests.Session()
                              self.sessionToken = None
                              self.id = str(generateuuid())
                              self.lastrequest_elapsed = None*/

        public object Dorequest(Dictionary<string, object> request_dict, string opname)
        {
            var json_request_dict = Newtonsoft.Json.JsonConvert.SerializeObject(request_dict);
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


    }


}