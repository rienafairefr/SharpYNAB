using System.Collections.Generic;
using Newtonsoft.Json;
using SharpnYNAB.Schema.Budget;
using SharpnYNAB.Schema.Types;
using System.Linq;
// ReSharper disable InconsistentNaming

namespace SharpnYNAB.Schema.Roots
{
    public class Budget : RootObj
    {
        public List<Transaction> be_transactions { get; set; } = new List<Transaction>();
        public List<MasterCategory> be_master_categories { get; set; } = new List<MasterCategory>();
        public List<Setting> be_settings { get; set; } = new List<Setting>();
        public List<MonthlyBudgetCalculation> be_monthly_budget_calculations { get; set; } = new List<MonthlyBudgetCalculation>();
        public List<AccountMapping> be_account_mappings { get; set; } = new List<AccountMapping>();
        public List<SubTransaction> be_subtransactions { get; set; } = new List<SubTransaction>();
        public List<ScheduledSubTransaction> be_scheduled_subtransactions { get; set; } = new List<ScheduledSubTransaction>();
        public List<MonthlyBudget> be_monthly_budgets { get; set; } = new List<MonthlyBudget>();
        public List<SubCategory> be_subcategories { get; set; } = new List<SubCategory>();
        public List<PayeeLocation> be_payee_locations { get; set; } = new List<PayeeLocation>();
        public List<AccountCalculation> be_account_calculations { get; set; } = new List<AccountCalculation>();
        public List<MonthlyAccountCalculation> be_monthly_account_calculations { get; set; } = new List<MonthlyAccountCalculation>();
        public List<MonthlySubCategoryBudgetCalculation> be_monthly_subcategory_budget_calculations { get; set; } = new List<MonthlySubCategoryBudgetCalculation>();
        public List<ScheduledTransaction> be_scheduled_transactions { get; set; } = new List<ScheduledTransaction>();
        public List<Payee> be_payees { get; set; } = new List<Payee>();
        public List<MonthlySubCategoryBudget> be_monthly_subcategory_budgets { get; set; } = new List<MonthlySubCategoryBudget>();
        public List<PayeeRenameCondition> be_payee_rename_conditions { get; set; } = new List<PayeeRenameCondition>();
        public List<Account> be_accounts { get; set; } = new List<Account>();
        public Date last_month { get; set; }
        public Date first_month { get; set; }
    }
}