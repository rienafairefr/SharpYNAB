using System.Collections.Generic;
using SharpnYNAB.Schema.Budget;
using SharpnYNAB.Schema.Roots;

// ReSharper disable InconsistentNaming

namespace SharpnYNAB.Schema
{
    public class Client
    {
        public Roots.Catalog catalog { get; set; }
        public Roots.Budget budget { get; set; }
        public BudgetVersion budget_version { get; set; }
        public string budget_name { get; set; }
        public int starting_device_knowledge { get; set; } = 0;
        public int ending_device_knowledge { get; set; } = 0;
        public string UserId => Connection.UserId;

        public CatalogClient CatalogClient { get; set; }
        public BudgetClient BudgetClient { get; set; }
        public IConnection Connection { get; set; }

        public Client()
        {
            budget = new Roots.Budget();
            catalog = new Roots.Catalog();
            CatalogClient = new CatalogClient(this);
            BudgetClient = new BudgetClient(this);
        }
        public void Sync()
        {
            CatalogClient.Sync();
            SelectBudget(budget_name);
            BudgetClient.Sync();
        }

        private void SelectBudget(string budgetName)
        {
            throw new System.NotImplementedException();
        }
    }

    public class BudgetClient : RootObjClient
    {
        public BudgetClient(Client client) : base(client, client.budget)
        {
        }

        public override Dictionary<string, object> Extra => new Dictionary<string, object>()
        {
            ["calculated_entities_included"] = false,
            ["budget_version_id"] = Client.budget_version.id
        };
        public override string opname => "syncBudgetData";
    }

    public class CatalogClient : RootObjClient
    {
        public CatalogClient(Client client) : base(client,client.catalog) { }
        public override Dictionary<string, object> Extra => new Dictionary<string, object>()
        {
            ["user_id"] = Client.UserId
        };
        public override string opname => "syncCatalogData";
    }

    public abstract class RootObjClient: IRootObjClient
    {
        public abstract Dictionary<string, object> Extra { get; }
        public abstract string opname { get; }
        public Client Client { get; set; }
        public Knowledge knowledge { get; set; }

        protected RootObjClient(Client client, RootObj obj)
        {
            Client = client;
            Obj = obj;
        }

        public RootObj Obj { get; set; }

        public void Sync()
        {
            var sync_data = GetSyncDataObj();
        }

        public object GetSyncDataObj()
        {
            var request_data = new Dictionary<string, object>
            {
                ["starting_device_knowledge"] = Client.starting_device_knowledge,
                ["ending_device_knowledge"] = Client.ending_device_knowledge, 
                ["device_knowledge_of_server"]= Obj.knowledge,
                ["changed_entities"] = new Dictionary<string, object>()

            };

            foreach (var keyValuePair in Extra)
            {
                request_data.Add(keyValuePair.Key,keyValuePair.Value);
            }

            return Connection.Dorequest(request_data, opname);
        }

        public IConnection Connection => Client.Connection;
    }

    public class Knowledge
    {
        public int current_device_knowledge { get; set; }
        public int device_knowledge_of_server { get; set; }
    }

    public interface IRootObjClient
    {
        void Sync();
    }
}
