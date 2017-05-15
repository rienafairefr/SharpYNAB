using Newtonsoft.Json;

namespace SharpnYNAB.Schema.Types
{
    public class DateFormat
    {
        [JsonProperty("format")]
        public string Format { get; set; }
    }
}
