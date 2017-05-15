using Newtonsoft.Json;

namespace SharpYNAB.Responses
{
    public class Response<T>
    {
        [JsonProperty("changed_entities")]
        public T ChangedEntities { get; set; }
        [JsonProperty("server_knowledge_of_device")]
        public int ServerKnowledgeOfDevice { get; set; }
        [JsonProperty("current_server_knowledge")]
        public int CurrentServerKnowledge { get; set; }
        [JsonProperty("error")]
        public ErrorData Error { get; set; }
    }
}
