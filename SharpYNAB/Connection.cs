using System.Collections.Generic;
using SharpYNAB.Schema;
using System.Net;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SharpYNAB.Contracts;
using SharpYNAB.Exceptions;
using SharpYNAB.Schema.Models;

namespace SharpYNAB
{
    public partial class Connection:IConnection
    {
        private readonly Uri _urlCatalog = new Uri("https://app.youneedabudget.com");
        private const string BaseCatalog = "/api/v1/catalog";
        private string SessionToken { get; set; }

        public CookieContainer Cookies { get; private set; }

        public LoginData LoginData { get; set; } = new LoginData
        {
            RememberMe = true,
            DeviceInfo = new DeviceInfo()
        };

        public Connection(string email, string password)
        {
            LoginData.Email = email;
            LoginData.Password = password;
            LoginData.DeviceInfo.Id = Utils.GenerateUuid();
        }

        public async Task InitSession()
        {
            Cookies = new CookieContainer();
            var firstLogin = await Dorequest(LoginData, "loginUser");
            var firstlogin = JsonConvert.DeserializeObject<FirstLoginResponse>(firstLogin);
            SessionToken = firstlogin.SessionToken;
            UserId = firstlogin.Userdata?.Id;
        }

        

        public async Task<string> Dorequest(object requestData, string opname)
        {
            var jsonRequestDict = JsonConvert.SerializeObject(requestData);
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
                requestmessage.Headers.Add("X-YNAB-Device-Id", LoginData.DeviceInfo.Id);
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
                                    return Dorequest(requestData, opname).Result;
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