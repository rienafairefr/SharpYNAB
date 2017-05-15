using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SharpYNAB.Schema.Budget;
using SharpYNAB.Schema.Roots;
using SharpYNAB.Schema.Types;
using SharpYNAB.Schema.Types.Converters;

namespace SharpYNAB.Schema
{
    public class EntityDict : Dictionary<string, object>
    {

    }
    public abstract class RootObjClient<T> : IRootObjClient where T : class, IRootObj, new()
    {
        public abstract Dictionary<string, object> Extra { get; }
        public abstract string opname { get; }
        public Client Client { get; set; }
        public Knowledge knowledge { get; set; }

        protected RootObjClient(Client client, T obj)
        {
            Client = client;
            Obj = obj;
            Changed = new T();
        }

        public T Obj { get; set; }

        public class Response
        {
            public T changed_entities { get; set; }
            public int server_knowledge_of_device { get; set; }
            public int current_server_knowledge { get; set; }
            public ErrorData  error { get; set; }
        }

        public T Changed { get; set; }

        public void ResetChanged()
        {
            Changed = new T();
        }

        public class ErrorData
        {
            public string id { get; set; }
        }

        protected PropertyChangedEventHandler GetSubCollectionItemChanged<T2>(
            ObservableCollection<T2> changedCollection) where T2 : class, IEntity
        {
            return (o, e) =>
            {
                var obj = (T2)o;
                if (!changedCollection.Contains(obj))
                {
                    changedCollection.Add(obj);
                }
            };
        }

        protected void ResetChangedItemWatchers<T2>(ObservableCollection<T2> changedCollection, IList collection) where T2: class, IEntity
        {
            if (collection != null)
            {
                foreach (T2 item in collection)
                    item.PropertyChanged += GetSubCollectionItemChanged(changedCollection);
            }
            else
            {
                
            }
        }

        protected void ResetChanged<T2>(ObservableCollection<T2> changedCollection, ObservableCollection<T2> collection) where T2 : class, IEntity
        {
            collection.CollectionChanged += GetSubCollectionChanged(changedCollection);
            ResetChangedItemWatchers(changedCollection, collection);
        }

        protected NotifyCollectionChangedEventHandler GetSubCollectionChanged<T2>(ObservableCollection<T2> changedCollection) where T2 : class, IEntity
        {
            return (o, e) =>
            {
                if (e.NewItems != null)
                {
                    ResetChangedItemWatchers(changedCollection, e.NewItems);
                }

                if (e.OldItems != null)
                    foreach (IEntity item in e.OldItems)
                        item.PropertyChanged -= GetSubCollectionItemChanged(changedCollection);
                switch (e.Action)
                {
                    case NotifyCollectionChangedAction.Add:
                        foreach (T2 obj in e.NewItems)
                        {
                            changedCollection.Add(obj);
                        }
                        break;
                    case NotifyCollectionChangedAction.Move:
                        break;
                    case NotifyCollectionChangedAction.Remove:
                        foreach (T2 obj in e.OldItems)
                        {
                            obj.is_tombstone = true;
                            if (!changedCollection.Contains(obj))
                            {
                                changedCollection.Add(obj);
                            }

                        }
                        break;
                    case NotifyCollectionChangedAction.Replace:
                        foreach (T2 obj in e.NewItems)
                        {
                            changedCollection.Add(obj);
                        }
                        foreach (T2 obj in e.OldItems)
                        {
                            obj.is_tombstone = true;
                            if (!changedCollection.Contains(obj))
                            {
                                changedCollection.Add(obj);
                            }
                        }
                        break;
                    case NotifyCollectionChangedAction.Reset:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            };
        }

        private JsonSerializerSettings jsonsettings = new JsonSerializerSettings
        {
            MissingMemberHandling = MissingMemberHandling.Error,
            Converters=new List<JsonConverter>
            {
                new DateConverter(),
                new AmountConverter(),
                new EscapedJsonConverter<DateFormat>(),
                new EscapedJsonConverter<CurrencyFormat>(),
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
            var change = currentServerKnowledge - Obj.Knowledge.DeviceKnowledgeOfServer;
            if (Obj.Knowledge.CurrentDeviceKnowledge < serverKnowledgeOfDevice)
            {
                Obj.Knowledge.CurrentDeviceKnowledge = serverKnowledgeOfDevice;
            }
            Obj.Knowledge.DeviceKnowledgeOfServer = currentServerKnowledge;
        }

        public async Task Push()
        {
        }

        public abstract void UpdateFromChangedEntities(T syncDataChangedEntities);

        public async Task<string> GetSyncDataObj()
        {
            var request_data = new Dictionary<string, object>
            {
                ["starting_device_knowledge"] = Client.StartingDeviceKnowledge,
                ["ending_device_knowledge"] = Client.EndingDeviceKnowledge,
                ["device_knowledge_of_server"] = Obj.Knowledge.DeviceKnowledgeOfServer,
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