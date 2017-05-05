using System.Collections.Generic;
using SharpnYNAB.Schema.Budget;
using SharpnYNAB.Schema.Types;
// ReSharper disable InconsistentNaming

namespace SharpnYNAB.Schema.Roots
{
    public class Budget: RootObj
    {
        public List<Transaction> be_transactions { get; set; }
        public List<MasterCategory> be_master_categories  { get; set; }
        public List<Setting> be_settings  { get; set; }
        public List<MonthlyBudgetCalculation> be_monthly_budget_calculations  { get; set; }
        public List<AccountMapping> be_account_mappings  { get; set; }
        public List<SubTransaction> be_subtransactions  { get; set; }
        public List<ScheduledSubTransaction> be_scheduled_subtransactions  { get; set; }
        public List<MonthlyBudget> be_monthly_budgets  { get; set; }
        public List<SubCategory> be_subcategories  { get; set; }
        public List<PayeeLocation> be_payee_locations  { get; set; }
        public List<AccountCalculation> be_account_calculations  { get; set; }
        public List<MonthlyAccountCalculation> be_monthly_account_calculations  { get; set; }
        public List<MonthlySubCategoryBudgetCalculation> be_monthly_subcategory_budget_calculations  { get; set; }
        public List<ScheduledTransaction> be_scheduled_transactions  { get; set; }
        public List<Payee> be_payees  { get; set; }
        public List<MonthlySubCategoryBudget> be_monthly_subcategory_budgets  { get; set; }
        public List<PayeeRenameCondition> be_payee_rename_conditions  { get; set; }
        public List<Account> be_accounts  { get; set; }
        public Date last_month { get; set; }
        public Date first_month { get; set; }
    }
}