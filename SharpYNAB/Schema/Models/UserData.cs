using Newtonsoft.Json;

namespace SharpYNAB.Schema.Models
{
    public class UserData
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}