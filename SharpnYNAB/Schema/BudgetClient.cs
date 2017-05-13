using System.Collections.Generic;

namespace SharpnYNAB.Schema
{
    public partial class BudgetClient : RootObjClient<Roots.Budget>
    {
        public BudgetClient(Client client) : base(client, client.budget)
        {
            
        }

        public new void ResetChanged()
        {
            base.ResetChanged();
        }

        public override Dictionary<string, object> Extra => new Dictionary<string, object>()
        {
            ["calculated_entities_included"] = false,
        };
        public override string opname => "syncBudgetData";
    }
}