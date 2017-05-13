using System.Collections.ObjectModel;
using Newtonsoft.Json;
using SharpnYNAB.Schema.Budget;
using SharpnYNAB.Schema.Types;

namespace SharpnYNAB.Schema.Roots
{
    public class Budget : RootObj
    {
        private Date _lastMonth;
        private Date _firstMonth;
        [JsonProperty("be_transactions")]
        public ObservableCollection<Transaction> Transactions { get; set; } = new ObservableCollection<Transaction>();
        [JsonProperty("be_master_categories")]
        public ObservableCollection<MasterCategory> MasterCategories { get; set; } = new ObservableCollection<MasterCategory>();
        [JsonProperty("be_settings")]
        public ObservableCollection<Setting> Settings { get; set; } = new ObservableCollection<Setting>();
        [JsonProperty("be_monthly_budget_calculations")]
        public ObservableCollection<MonthlyBudgetCalculation> MonthlyBudgetCalculations { get; set; } = new ObservableCollection<MonthlyBudgetCalculation>();
        [JsonProperty("be_account_mappings")]
        public ObservableCollection<AccountMapping> AccountMappings { get; set; } = new ObservableCollection<AccountMapping>();
        [JsonProperty("be_subtransactions")]
        public ObservableCollection<Subtransaction> Subtransactions { get; set; } = new ObservableCollection<Subtransaction>();
        [JsonProperty("be_scheduled_subtransactions")]
        public ObservableCollection<ScheduledSubtransaction> ScheduledSubtransactions { get; set; } = new ObservableCollection<ScheduledSubtransaction>();
        [JsonProperty("be_monthly_budgets")]
        public ObservableCollection<MonthlyBudget> MonthlyBudgets { get; set; } = new ObservableCollection<MonthlyBudget>();
        [JsonProperty("be_subcategories")]
        public ObservableCollection<Subcategory> Subcategories { get; set; } = new ObservableCollection<Subcategory>();
        [JsonProperty("be_payee_locations")]
        public ObservableCollection<PayeeLocation> PayeeLocations { get; set; } = new ObservableCollection<PayeeLocation>();
        [JsonProperty("be_account_calculations")]
        public ObservableCollection<AccountCalculation> AccountCalculations { get; set; } = new ObservableCollection<AccountCalculation>();
        [JsonProperty("be_monthly_account_calculations")]
        public ObservableCollection<MonthlyAccountCalculation> MonthlyAccountCalculations { get; set; } = new ObservableCollection<MonthlyAccountCalculation>();
        [JsonProperty("be_monthly_subcategory_budget_calculations")]
        public ObservableCollection<MonthlySubcategoryBudgetCalculation> MonthlySubcategoryBudgetCalculations { get; set; } = new ObservableCollection<MonthlySubcategoryBudgetCalculation>();
        [JsonProperty("be_scheduled_transactions")]
        public ObservableCollection<ScheduledTransaction> ScheduledTransactions { get; set; } = new ObservableCollection<ScheduledTransaction>();
        [JsonProperty("be_payees")]
        public ObservableCollection<Payee> Payees { get; set; } = new ObservableCollection<Payee>();
        [JsonProperty("be_monthly_subcategory_budgets")]
        public ObservableCollection<MonthlySubcategoryBudget> MonthlySubcategoryBudgets { get; set; } = new ObservableCollection<MonthlySubcategoryBudget>();
        [JsonProperty("be_payee_rename_conditions")]
        public ObservableCollection<PayeeRenameCondition> PayeeRenameConditions { get; set; } = new ObservableCollection<PayeeRenameCondition>();
        [JsonProperty("be_accounts")]
        public ObservableCollection<Account> Accounts { get; set; } = new ObservableCollection<Account>();

        [JsonProperty("last_month")]
        public Date LastMonth
        {
            get => _lastMonth;
            set { _lastMonth = value; OnPropertyChanged(); }
        }

        [JsonProperty("first_month")]
        public Date FirstMonth
        {
            get => _firstMonth;
            set { _firstMonth = value; OnPropertyChanged(); }
        }

        public override int Size => Transactions.Count + MasterCategories.Count + Settings.Count +
                                    MonthlyBudgetCalculations.Count + AccountMappings.Count +
                                    Subtransactions.Count + ScheduledSubtransactions.Count +
                                    MonthlyBudgets.Count + Subcategories.Count + PayeeLocations.Count +
                                    AccountCalculations.Count + MonthlyAccountCalculations.Count +
                                    MonthlySubcategoryBudgetCalculations.Count + ScheduledTransactions.Count +
                                    Payees.Count + MonthlySubcategoryBudgets.Count +
                                    PayeeRenameConditions.Count + Accounts.Count;
    }
}