using Newtonsoft.Json;

namespace SharpYNAB.Responses
{
    public class ErrorData
    {
        [JsonProperty("id")]
        public YnabError? Id { get; set; }
    }
}