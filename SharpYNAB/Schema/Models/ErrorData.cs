using Newtonsoft.Json;

namespace SharpYNAB.Schema.Models
{
    public class ErrorData
    {
        [JsonProperty("id")]
        public YnabError? Id { get; set; }
    }
}