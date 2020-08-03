using Newtonsoft.Json;

namespace SharpYNAB.Schema.Models
{
    public enum YnabError
    {
        [JsonProperty("user_not_found")]
        UserNotFound,
        [JsonProperty("user_password_invalid")]
        UserPasswordInvalid,
        [JsonProperty("request_throttled")]
        RequestThrottled
    }
}