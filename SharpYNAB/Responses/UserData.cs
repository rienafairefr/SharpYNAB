using Newtonsoft.Json;

namespace SharpYNAB.Responses
{
    public class UserData
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}