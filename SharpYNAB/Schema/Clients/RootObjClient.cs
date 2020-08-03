using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SharpYNAB.Contracts;
using SharpYNAB.Schema.Contracts;
using SharpYNAB.Schema.Models;
using SharpYNAB.Schema.Models.Contracts;
using SharpYNAB.Schema.Roots.Contracts;
using SharpYNAB.Schema.Types;
using SharpYNAB.Schema.Types.Converters;

namespace SharpYNAB.Schema.Clients
{
    public abstract class RootObjClient<T> : IRootObjClient where T : class, IRootObj, new()
    {
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
            Client.Context.SaveChanges();
            ResetChanged();
        }

        public async Task Push()
        {
            Incorporate(await GetPushSyncDataObj());
        }

        public async Task Sync()
        {
            Incorporate(await GetPushSyncDataObj());
        }

        public IClientData<T> SetupCommonClientData(IClientData<T> clientdata)
        {
            clientdata.StartingDeviceKnowledge = Client.StartingDeviceKnowledge;
            clientdata.EndingDeviceKnowledge = Client.EndingDeviceKnowledge;
            clientdata.DeviceKnowledgeOfServer = Obj.Knowledge.DeviceKnowledgeOfServer;
            clientdata.Changed = Changed;
            return clientdata;
        }

        public abstract IClientData<T> GetClientData();

        public abstract void UpdateFromChangedEntities(T syncDataChangedEntities);

        public async Task<string> GetPushSyncDataObj()
        {
            return await Connection.Dorequest(SetupCommonClientData(GetClientData()), Opname);
        }

        public IConnection Connection => Client.Connection;
    }
}