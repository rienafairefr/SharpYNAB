using System.Collections.Generic;
using SharpnYNAB.Schema.Budget;
using SharpnYNAB.Schema.Catalog;

// ReSharper disable InconsistentNaming

namespace SharpnYNAB.Schema.Roots
{
    public class Catalog : RootObj
    {
        public List<UserBudget> ce_user_budgets { get; set; } = new List<UserBudget>();
        public List<UserSetting> ce_user_settings { get; set; } = new List<UserSetting>();
        public List<BudgetVersion> ce_budget_versions { get; set; } = new List<BudgetVersion>();
        public List<User> ce_users { get; set; } = new List<User>();
        public List<CatalogBudget> ce_budgets { get; set; } = new List<CatalogBudget>();

        public override int Size => ce_user_budgets.Count + ce_user_settings.Count + ce_budget_versions.Count +
                                    ce_users.Count + ce_budgets.Count;
    }
}