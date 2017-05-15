using System.Collections.Generic;
using SharpYNAB.Exceptions;

namespace SharpYNAB.Schema.Clients
{
    public partial class BudgetClient : RootObjClient<Roots.Budget>
    {
        public BudgetClient(Client client) : base(client, client.Budget) { }

        public override Dictionary<string, object> Extra
        {
            get
            {
                if (Client.BudgetVersion == null) throw new NoSelectedBudgetException();
                return new Dictionary<string, object>()
                {
                    ["calculated_entities_included"] = false,
                    ["budget_version_id"] = Client.BudgetVersion.Id
                };
            }
        }

        public override string Opname => "syncBudgetData";
    }
}