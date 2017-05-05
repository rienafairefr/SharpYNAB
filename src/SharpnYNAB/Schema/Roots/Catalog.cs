using System.Collections.Generic;
using SharpnYNAB.Schema.Budget;
using SharpnYNAB.Schema.Catalog;

// ReSharper disable InconsistentNaming

namespace SharpnYNAB.Schema.Roots
{
    public class Catalog: RootObj
    {
        public List<UserBudget> ce_user_budgets { get; set; }
        public List<UserSetting> ce_user_settings { get; set; }
        public List<BudgetVersion> ce_budget_versions { get; set; }
        public List<User> ce_users { get; set; }
        public List<CatalogBudget> ce_budgets { get; set; }
    }
}