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
            ResetChanged(Changed.be_accounts, Obj.be_accounts);
            ResetChanged(Changed.be_account_calculations, Obj.be_account_calculations);
        }

        public override Dictionary<string, object> Extra => new Dictionary<string, object>()
        {
            ["calculated_entities_included"] = false,
            ["budget_version_id"] = Client.budget_version.id
        };
        public override string opname => "syncBudgetData";
    }
}