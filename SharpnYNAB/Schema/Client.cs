using System.Collections.Generic;
using System.Threading.Tasks;
using SharpnYNAB.Schema.Budget;
using SharpnYNAB.Schema.Catalog;

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
        public async Task Sync()
        {
            await CatalogClient.Sync();
            SelectBudget(budget_name);
            await BudgetClient.Sync();
        }

        private void SelectBudget(string budgetName)
        {
            throw new System.NotImplementedException();
        }
    }

    public partial class BudgetClient : RootObjClient<Roots.Budget>
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

    public partial class CatalogClient : RootObjClient<Roots.Catalog>
    {
        public CatalogClient(Client client) : base(client,client.catalog) { }
        public override Dictionary<string, object> Extra => new Dictionary<string, object>()
        {
            ["user_id"] = Client.UserId
        };
        public override string opname => "syncCatalogData";
    }

    public class Knowledge
    {
        public int current_device_knowledge { get; set; }
        public int device_knowledge_of_server { get; set; }
    }

    public interface IRootObjClient
    {
        Task Sync();
    }
}
