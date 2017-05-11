using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
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
        public int starting_device_knowledge { get; set; }
        public int ending_device_knowledge { get; set; }
        public string UserId => Connection.UserId;

        [NotMapped]
        public CatalogClient CatalogClient { get; set; }
        [NotMapped]
        public BudgetClient BudgetClient { get; set; }
        [NotMapped]
        public IConnection Connection { get; set; }

        public Client()
        {
            budget = new Roots.Budget();
            catalog = new Roots.Catalog();
            CatalogClient = new CatalogClient(this);
            BudgetClient = new BudgetClient(this);
            CatalogClient.ResetChanged();
            BudgetClient.ResetChanged();
        }

        public async Task Push(int expected_delta)
        {
            var catalog_changed_entities = CatalogClient.Changed;
            var budget_changed_entities = BudgetClient.Changed;
            var delta = catalog_changed_entities.Size + budget_changed_entities.Size;
            if (delta != expected_delta)
            {
                throw new WrongPushException();
            }
            if (delta > 0)
            {
                ending_device_knowledge = starting_device_knowledge + 1;

                await CatalogClient.Push();
                await BudgetClient.Push();
                starting_device_knowledge = ending_device_knowledge;
            }
        }

        public async Task Sync()
        {
            await CatalogClient.Sync();
            SelectBudget(budget_name);
            await BudgetClient.Sync();
        }

        private void SelectBudget(string budgetName)
        {
            budget_version = catalog.ce_budget_versions.FirstOrDefault(bv => bv.version_name == budgetName);
            if (budget_version == null)
            {
                throw new BudgetNotFoundException();
            }
        }
    }

    public class WrongPushException : Exception
    {
    }
}
