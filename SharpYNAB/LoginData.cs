using Newtonsoft.Json;
using SharpYNAB.Schema.Models;

namespace SharpYNAB
{
    public class LoginData
    {
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }
        [JsonProperty("remember_me")]
        public bool RememberMe { get; set; }
        [JsonProperty("device_info")]
        public DeviceInfo DeviceInfo { get; set; }
    }
}