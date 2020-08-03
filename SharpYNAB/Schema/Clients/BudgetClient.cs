using SharpYNAB.Exceptions;
using SharpYNAB.Schema.Models;
using SharpYNAB.Schema.Models.Contracts;

namespace SharpYNAB.Schema.Clients
{
    public partial class BudgetClient : RootObjClient<Roots.Budget>
    {
        public BudgetClient(Client client) : base(client, client.Budget) { }

        public override string Opname => "syncBudgetData";
        public override IClientData<Roots.Budget> GetClientData()
        {
            if (Client.BudgetVersion == null) throw new NoSelectedBudgetException();
            return new BudgetData
            {
                CalculatedEntitiesIncluded = false,
                BudgetVersionId = Client.BudgetVersion.Id
            };
        }
    }
}