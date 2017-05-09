using System.Collections.Generic;
using SharpnYNAB.Schema;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
// ReSharper disable InconsistentNaming

namespace SharpnYNAB
{

    public partial class Connection : IConnection
    {
        public class YnabResponse
        {
            [JsonConverter(typeof(StringEnumConverter))]
            public YnabError? error { get; set; }

            public string session_token { get; set; }
            public ResponseUser user { get; set; }
            public int server_knowledge_of_device { get; set; }
            public int current_server_knowledge;
        }
    }
}