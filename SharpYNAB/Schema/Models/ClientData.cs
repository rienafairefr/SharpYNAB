using Newtonsoft.Json;
using SharpYNAB.Schema.Models.Contracts;

namespace SharpYNAB.Schema.Models
{
    public class ClientData<T>:IClientData<T>
    {
        [JsonProperty("starting_device_knowledge")]
        public int StartingDeviceKnowledge { get; set; }
        [JsonProperty("ending_device_knowledge")]
        public int EndingDeviceKnowledge { get; set; }
        [JsonProperty("device_knowledge_of_server")]
        public int DeviceKnowledgeOfServer { get; set; }
        [JsonProperty("changed_entities")]
        public T Changed { get; set; }
    }
}