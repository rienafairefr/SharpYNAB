using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SharpYNAB.Contracts;
using SharpYNAB.Responses;
using SharpYNAB.Schema.Contracts;
using SharpYNAB.Schema.Roots.Contracts;
using SharpYNAB.Schema.Types;
using SharpYNAB.Schema.Types.Converters;

namespace SharpYNAB.Schema.Clients
{
    public abstract class RootObjClient<T> : IRootObjClient where T : class, IRootObj, new()
    {
        public abstract Dictionary<string, object> Extra { get; }
        public abstract string Opname { get; }
        public Client Client { get; set; }
        public Knowledge Knowledge { get; set; }

        protected RootObjClient(Client client, T obj)
        {
            Client = client;
            Obj = obj;
            Changed = new T();
        }

        public T Obj { get; set; }

        public T Changed { get; set; }

        public void ResetChanged()
        {
            Changed = new T();
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
                        if (e.NewItems != null)
                        {
                            foreach (T2 obj in e.NewItems)
                            {
                                changedCollection.Add(obj);
                            }
                        }
                        break;
                    case NotifyCollectionChangedAction.Move:
                        break;
                    case NotifyCollectionChangedAction.Remove:
                        if (e.OldItems != null)
                        {
                            foreach (T2 obj in e.OldItems)
                            {
                                obj.IsTombstone = true;
                                if (!changedCollection.Contains(obj))
                                {
                                    changedCollection.Add(obj);
                                }
                            }
                        }
                        break;
                    case NotifyCollectionChangedAction.Replace:
                        if (e.NewItems != null)
                        {
                            foreach (T2 obj in e.NewItems)
                            {
                                changedCollection.Add(obj);
                            }
                        }
                        if (e.OldItems != null)
                        {
                            foreach (T2 obj in e.OldItems)
                            {
                                obj.IsTombstone = true;
                                if (!changedCollection.Contains(obj))
                                {
                                    changedCollection.Add(obj);
                                }
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

        public void Incorporate(string data)
        {
            var response = JsonConvert.DeserializeObject<Response<T>>(data, jsonsettings);
            UpdateFromChangedEntities(response.ChangedEntities);
            var serverKnowledgeOfDevice = response.ServerKnowledgeOfDevice;
            var currentServerKnowledge = response.CurrentServerKnowledge;
            if (Obj.Knowledge.CurrentDeviceKnowledge < serverKnowledgeOfDevice)
            {
                Obj.Knowledge.CurrentDeviceKnowledge = serverKnowledgeOfDevice;
            }
            Obj.Knowledge.DeviceKnowledgeOfServer = currentServerKnowledge;
        }

        public async Task Push()
        {
            Incorporate(await GetPushDataObj());
        }

        public async Task Sync()
        {
            Incorporate(await GetSyncDataObj());
        }

        public async Task<string> GetPushDataObj()
        {
            var requestData = new Dictionary<string, object>
            {
                ["starting_device_knowledge"] = Client.StartingDeviceKnowledge,
                ["ending_device_knowledge"] = Client.EndingDeviceKnowledge,
                ["device_knowledge_of_server"] = Obj.Knowledge.DeviceKnowledgeOfServer,
                ["changed_entities"] = Changed

            };

            foreach (var keyValuePair in Extra)
            {
                requestData.Add(keyValuePair.Key, keyValuePair.Value);
            }

            return await Connection.Dorequest(requestData, Opname);
        }

        public abstract void UpdateFromChangedEntities(T syncDataChangedEntities);

        public async Task<string> GetSyncDataObj()
        {
            var requestData = new Dictionary<string, object>
            {
                ["starting_device_knowledge"] = Client.StartingDeviceKnowledge,
                ["ending_device_knowledge"] = Client.EndingDeviceKnowledge,
                ["device_knowledge_of_server"] = Obj.Knowledge.DeviceKnowledgeOfServer,
                ["changed_entities"] = new Dictionary<string, object>()

            };

            foreach (var keyValuePair in Extra)
            {
                requestData.Add(keyValuePair.Key, keyValuePair.Value);
            }

            return await Connection.Dorequest(requestData, Opname);
        }

        public IConnection Connection => Client.Connection;
    }
}