using Newtonsoft.Json;

namespace SharpYNAB.Responses
{
    public class ErrorData
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}