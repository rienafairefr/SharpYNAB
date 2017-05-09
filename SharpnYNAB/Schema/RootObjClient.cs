using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SharpnYNAB.Schema.Catalog;
using SharpnYNAB.Schema.Roots;
using SharpnYNAB.Schema.Types;
using SharpnYNAB.Schema.Types.Converters;

namespace SharpnYNAB.Schema
{
    public class EntityDict : Dictionary<string, object>
    {

    }
    public abstract class RootObjClient<T> : IRootObjClient where T : IRootObj
    {
        public abstract Dictionary<string, object> Extra { get; }
        public abstract string opname { get; }
        public Client Client { get; set; }
        public Knowledge knowledge { get; set; }

        protected RootObjClient(Client client, T obj)
        {
            Client = client;
            Obj = obj;
        }

        public T Obj { get; set; }

        public class Response
        {
            public T changed_entities { get; set; }
            public int server_knowledge_of_device { get; set; }
            public int current_server_knowledge { get; set; }
            public ErrorData  error { get; set; }
        }

        public class ErrorData
        {
            public string id { get; set; }
        }

        private JsonSerializerSettings jsonsettings = new JsonSerializerSettings
        {
            MissingMemberHandling = MissingMemberHandling.Error,
            Converters=new List<JsonConverter>
            {
                new DateConverter(),
                new AmountConverter(),
                new CurrencyFormatConverter(),
                new IdConverter()
            }

        };
        public async Task Sync()
        {
            var syncData = await GetSyncDataObj();
            var response = JsonConvert.DeserializeObject<Response>(syncData, jsonsettings);
            UpdateFromChangedEntities(response.changed_entities);
            var serverKnowledgeOfDevice = response.server_knowledge_of_device;
            var currentServerKnowledge = response.current_server_knowledge;
            var change = currentServerKnowledge - Obj.knowledge.device_knowledge_of_server;
            if (Obj.knowledge.current_device_knowledge < serverKnowledgeOfDevice)
            {
                Obj.knowledge.current_device_knowledge = serverKnowledgeOfDevice;
            }
            Obj.knowledge.device_knowledge_of_server = currentServerKnowledge;
        }

        public abstract void UpdateFromChangedEntities(T syncDataChangedEntities);

        public async Task<string> GetSyncDataObj()
        {
            var request_data = new Dictionary<string, object>
            {
                ["starting_device_knowledge"] = Client.starting_device_knowledge,
                ["ending_device_knowledge"] = Client.ending_device_knowledge,
                ["device_knowledge_of_server"] = Obj.knowledge.device_knowledge_of_server,
                ["changed_entities"] = new Dictionary<string, object>()

            };

            foreach (var keyValuePair in Extra)
            {
                request_data.Add(keyValuePair.Key, keyValuePair.Value);
            }

            return await Connection.Dorequest(request_data, opname);
        }

        public IConnection Connection => Client.Connection;
    }
}