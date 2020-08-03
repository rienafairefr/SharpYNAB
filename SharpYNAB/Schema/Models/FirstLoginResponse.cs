using Newtonsoft.Json;

namespace SharpYNAB.Schema.Models
{
    public class FirstLoginResponse
    {
        [JsonProperty("session_token")]
        public string SessionToken { get; set; }
        [JsonProperty("userdata")]
        public UserData Userdata { get; set; }
    }
}