using System.Collections.ObjectModel;
using SharpnYNAB.Schema.Budget;
using SharpnYNAB.Schema.Types;

// ReSharper disable InconsistentNaming

namespace SharpnYNAB.Schema.Roots
{
    public class Budget : RootObj
    {
        private Date _lastMonth;
        private Date _firstMonth;
        public ObservableCollection<Transaction> be_transactions { get; set; } = new ObservableCollection<Transaction>();
        public ObservableCollection<MasterCategory> be_master_categories { get; set; } = new ObservableCollection<MasterCategory>();
        public ObservableCollection<Setting> be_settings { get; set; } = new ObservableCollection<Setting>();
        public ObservableCollection<MonthlyBudgetCalculation> be_monthly_budget_calculations { get; set; } = new ObservableCollection<MonthlyBudgetCalculation>();
        public ObservableCollection<AccountMapping> be_account_mappings { get; set; } = new ObservableCollection<AccountMapping>();
        public ObservableCollection<SubTransaction> be_subtransactions { get; set; } = new ObservableCollection<SubTransaction>();
        public ObservableCollection<ScheduledSubTransaction> be_scheduled_subtransactions { get; set; } = new ObservableCollection<ScheduledSubTransaction>();
        public ObservableCollection<MonthlyBudget> be_monthly_budgets { get; set; } = new ObservableCollection<MonthlyBudget>();
        public ObservableCollection<SubCategory> be_subcategories { get; set; } = new ObservableCollection<SubCategory>();
        public ObservableCollection<PayeeLocation> be_payee_locations { get; set; } = new ObservableCollection<PayeeLocation>();
        public ObservableCollection<AccountCalculation> be_account_calculations { get; set; } = new ObservableCollection<AccountCalculation>();
        public ObservableCollection<MonthlyAccountCalculation> be_monthly_account_calculations { get; set; } = new ObservableCollection<MonthlyAccountCalculation>();
        public ObservableCollection<MonthlySubCategoryBudgetCalculation> be_monthly_subcategory_budget_calculations { get; set; } = new ObservableCollection<MonthlySubCategoryBudgetCalculation>();
        public ObservableCollection<ScheduledTransaction> be_scheduled_transactions { get; set; } = new ObservableCollection<ScheduledTransaction>();
        public ObservableCollection<Payee> be_payees { get; set; } = new ObservableCollection<Payee>();
        public ObservableCollection<MonthlySubCategoryBudget> be_monthly_subcategory_budgets { get; set; } = new ObservableCollection<MonthlySubCategoryBudget>();
        public ObservableCollection<PayeeRenameCondition> be_payee_rename_conditions { get; set; } = new ObservableCollection<PayeeRenameCondition>();
        public ObservableCollection<Account> be_accounts { get; set; } = new ObservableCollection<Account>();

        public Budget()
        {
            be_accounts.CollectionChanged += (o, e) => { };
        }

        public Date last_month
        {
            get => _lastMonth;
            set { _lastMonth = value; OnPropertyChanged(); }
        }

        public Date first_month
        {
            get => _firstMonth;
            set { _firstMonth = value; OnPropertyChanged(); }
        }

        public override int Size => be_transactions.Count + be_master_categories.Count + be_settings.Count +
                                    be_monthly_budget_calculations.Count + be_account_mappings.Count +
                                    be_subtransactions.Count + be_scheduled_subtransactions.Count +
                                    be_monthly_budgets.Count + be_subcategories.Count + be_payee_locations.Count +
                                    be_account_calculations.Count + be_monthly_account_calculations.Count +
                                    be_monthly_subcategory_budget_calculations.Count + be_scheduled_transactions.Count +
                                    be_payees.Count + be_monthly_subcategory_budgets.Count +
                                    be_payee_rename_conditions.Count + be_accounts.Count;
    }
}