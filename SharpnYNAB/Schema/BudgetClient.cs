using System.Collections.Generic;

namespace SharpnYNAB.Schema
{
    public partial class BudgetClient : RootObjClient<Roots.Budget>
    {
        public BudgetClient(Client client) : base(client, client.Budget)
        {
            
        }

        public new void ResetChanged()
        {
            base.ResetChanged();
            ResetChanged(Changed.Accounts, Obj.Accounts);
            ResetChanged(Changed.AccountCalculations, Obj.AccountCalculations);
        }

        public override Dictionary<string, object> Extra => new Dictionary<string, object>()
        {
            ["calculated_entities_included"] = false,
            ["budget_version_id"] = Client.BudgetVersion.id
        };
        public override string opname => "syncBudgetData";
    }
}