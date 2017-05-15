using System.Collections.Generic;
using SharpYNAB.Schema;
using System.Net;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SharpYNAB.Contracts;
using SharpYNAB.Exceptions;
using SharpYNAB.Responses;

namespace SharpYNAB
{
    public partial class Connection:IConnection
    {
        private readonly Uri _urlCatalog = new Uri("https://app.youneedabudget.com");
        private const string BaseCatalog = "/api/v1/catalog";
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

        

        public async Task init_session()
        {
            Cookies = new CookieContainer();
            var firstLogin = await Dorequest(new Dictionary<string, object>
            {
                ["email"] = Email,
                ["password"] = Password,
                ["remember_me"] = true,
                ["device_info"] = new Dictionary<string, object>
                {
                    ["id"] = Id
                }
            }, "loginUser");
            var firstlogin = JsonConvert.DeserializeObject<FirstLoginResponse>(firstLogin);
            SessionToken = firstlogin.SessionToken;
            UserId = firstlogin.Userdata?.Id;
        }

        

        public async Task<string> Dorequest(Dictionary<string, object> requestDict, string opname)
        {
            var jsonRequestDict = JsonConvert.SerializeObject(requestDict);
            using (var handler = new HttpClientHandler()
            {
                CookieContainer = Cookies,
                UseCookies = true
            })
            using (var client = new HttpClient(handler)
            {
                BaseAddress = _urlCatalog,
            })
            {
                var requestmessage = new HttpRequestMessage(HttpMethod.Post, BaseCatalog);
                requestmessage.Headers.Add("User-Agent", "C# client for YNAB rienafairefr");
                requestmessage.Headers.Add("X-YNAB-Device-Id", Id);
                if (SessionToken != null)
                {
                    requestmessage.Headers.Add("X-Session-Token", SessionToken);
                }
                requestmessage.Content = new FormUrlEncodedContent(new Dictionary<string, string>
                {
                    ["operation_name"] = opname,
                    ["request_data"] = jsonRequestDict,
                });


                var response = await client.SendAsync(requestmessage);
                switch (response.StatusCode)
                {
                    case HttpStatusCode.InternalServerError:
                        break;
                    case HttpStatusCode.OK:
                        var responsecontent = await response.Content.ReadAsStringAsync();
                        var js = JsonConvert.DeserializeObject<YnabResponse>(responsecontent);
                        switch (js.error)
                        {
                            case null:
                                return responsecontent;
                            case YnabError.UserNotFound:
                                throw new UserNotFoundException();
                            case YnabError.UserPasswordInvalid:
                                throw new UserPasswordInvalidException();
                            case YnabError.RequestThrottled:
                                var retryrafter = response.Headers.RetryAfter.Delta?.Milliseconds;
                                if (retryrafter != null)
                                {
                                    await Task.Delay((int)retryrafter);
                                    return Dorequest(requestDict, opname).Result;
                                }
                                break;
                            default:
                                throw new ArgumentOutOfRangeException();
                        }
                        break;
                }
            }


            return null;
        }

        public string UserId { get; set; }
    }
}