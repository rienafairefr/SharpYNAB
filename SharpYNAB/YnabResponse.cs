using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SharpYNAB
{
    public partial class Connection : IConnection
    {
        public class YnabResponse
        {
            [JsonConverter(typeof(StringEnumConverter))]
            [JsonProperty("error")]
            public YnabError? error { get; set; }

            [JsonProperty("session_token")]
            public string SessionToken { get; set; }
            [JsonProperty("user")]
            public ResponseUser User { get; set; }
            [JsonProperty("server_knowledge_of_device")]
            public int ServerKnowledgeOfDevice { get; set; }
            [JsonProperty("current_server_knowledge")]
            public int CurrentServerKnowledge;
        }
    }
}