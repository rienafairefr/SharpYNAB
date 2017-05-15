using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using SharpnYNAB.Schema.Budget;
using SharpnYNAB.Schema.Catalog;

namespace SharpnYNAB.Schema
{
    public class Client
    {
        public int Id { get; set; }
        public Roots.Catalog Catalog { get; set; }
        public Roots.Budget Budget { get; set; }

        public BudgetVersion BudgetVersion { get; set; }
        public string BudgetName { get; set; }
        public int StartingDeviceKnowledge { get; set; }
        public int EndingDeviceKnowledge { get; set; }
        public string UserId => Connection.UserId;

        [NotMapped]
        public CatalogClient CatalogClient { get; set; }
        [NotMapped]
        public BudgetClient BudgetClient { get; set; }
        [NotMapped]
        public IConnection Connection { get; set; }

        public Client()
        {
            Budget = new Roots.Budget();
            Catalog = new Roots.Catalog();
            CatalogClient = new CatalogClient(this);
            BudgetClient = new BudgetClient(this);
            CatalogClient.ResetChanged();
            BudgetClient.ResetChanged();
        }

        public async Task Push(int expectedDelta)
        {
            var catalogChangedEntities = CatalogClient.Changed;
            var budgetChangedEntities = BudgetClient.Changed;
            var delta = catalogChangedEntities.Size + budgetChangedEntities.Size;
            if (delta != expectedDelta)
            {
                throw new WrongPushException();
            }
            if (delta > 0)
            {
                EndingDeviceKnowledge = StartingDeviceKnowledge + 1;

                await CatalogClient.Push();
                await BudgetClient.Push();
                StartingDeviceKnowledge = EndingDeviceKnowledge;
            }
        }

        public async Task Sync()
        {
            await CatalogClient.Sync();
            SelectBudget();
            await BudgetClient.Sync();
        }

        public void SelectBudget()
        {
            BudgetVersion = Catalog.BudgetVersions.FirstOrDefault(bv => bv.VersionName == BudgetName);
            if (BudgetVersion == null)
            {
                throw new BudgetNotFoundException();
            }
        }
    }

    public class WrongPushException : Exception
    {
    }
}
