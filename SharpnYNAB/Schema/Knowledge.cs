using Newtonsoft.Json;

namespace SharpnYNAB.Schema
{
    public class Knowledge
    {
        [JsonIgnore]
        public int Id { get; set; }
        [JsonProperty("current_device_knowledge")]
        public int CurrentDeviceKnowledge { get; set; }
        [JsonProperty("device_knowledge_of_server")]
        public int DeviceKnowledgeOfServer { get; set; }
    }
}