using Newtonsoft.Json;

namespace SharpYNAB.Schema.Models
{
    public class DeviceInfo
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}