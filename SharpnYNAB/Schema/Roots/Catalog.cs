using System.Collections.Generic;
using Newtonsoft.Json;
using SharpnYNAB.Schema.Catalog;

namespace SharpnYNAB.Schema.Roots
{
    public class Catalog : RootObj
    {
        [JsonProperty("ce_user_budgets")]
        public List<UserBudget> UserBudgets { get; set; } = new List<UserBudget>();
        [JsonProperty("ce_user_settings")]
        public List<UserSetting> UserSettings { get; set; } = new List<UserSetting>();
        [JsonProperty("ce_budget_versions")]
        public List<BudgetVersion> BudgetVersions { get; set; } = new List<BudgetVersion>();
        [JsonProperty("ce_users")]
        public List<User> Users { get; set; } = new List<User>();
        [JsonProperty("ce_budgets")]
        public List<CatalogBudget> Budgets { get; set; } = new List<CatalogBudget>();

        public override int Size => UserBudgets.Count + UserSettings.Count + BudgetVersions.Count +
                                    Users.Count + Budgets.Count;
    }
}