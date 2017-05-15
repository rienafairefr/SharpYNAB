using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using SharpYNAB.Schema.Catalog;

namespace SharpYNAB.Schema.Roots
{
    public class Catalog : RootObj
    {
        [JsonProperty("ce_user_budgets")]
        public ObservableCollection<UserBudget> UserBudgets { get; set; } = new ObservableCollection<UserBudget>();
        [JsonProperty("ce_user_settings")]
        public ObservableCollection<UserSetting> UserSettings { get; set; } = new ObservableCollection<UserSetting>();
        [JsonProperty("ce_budget_versions")]
        public ObservableCollection<BudgetVersion> BudgetVersions { get; set; } = new ObservableCollection<BudgetVersion>();
        [JsonProperty("ce_users")]
        public ObservableCollection<User> Users { get; set; } = new ObservableCollection<User>();
        [JsonProperty("ce_budgets")]
        public ObservableCollection<CatalogBudget> Budgets { get; set; } = new ObservableCollection<CatalogBudget>();

        public override int Size => UserBudgets.Count + UserSettings.Count + BudgetVersions.Count +
                                    Users.Count + Budgets.Count;
    }
}