using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using SharpYNAB.Schema.Catalog;

namespace SharpYNAB.Schema
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

        public void Push(int expectedDelta)
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

                Task.Run(()=>CatalogClient.Push()).Wait();
                Task.Run(() => BudgetClient.Push()).Wait();
                StartingDeviceKnowledge = EndingDeviceKnowledge;
            }
        }

        public void Sync()
        {
            Task.Run(() => CatalogClient.Sync()).Wait();
            SelectBudget();
            Task.Run(() => BudgetClient.Sync()).Wait();
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
