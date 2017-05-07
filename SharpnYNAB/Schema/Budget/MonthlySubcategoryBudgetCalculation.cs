using SharpnYNAB.Schema.Types;
// ReSharper disable InconsistentNaming

namespace SharpnYNAB.Schema.Budget
{
    public class MonthlySubCategoryBudgetCalculation
    {
        public string additional_to_be_budgeted { get; set; }
        public Amount all_spending { get; set; }
        public Amount all_spending_since_last_payment { get; set; }
        public Amount balance { get; set; }
        public Amount balance_previous_month { get; set; }
        public Amount budgeted_average { get; set; }
        public Amount budgeted_cash_outflows { get; set; }
        public Amount budgeted_credit_outflows { get; set; }
        public Amount budgeted_previous_month { get; set; }
        public Amount budgeted_spending { get; set; }
        public Amount cash_outflows { get; set; }
        public Amount credit_outflows { get; set; }
        public MonthlySubCategoryBudget entities_monthly_subcategory_budget { get; set; }
        public string goal_expected_completion { get; set; }
        public Amount goal_overall_funded { get; set; }
        public Amount goal_overall_left { get; set; }
        public string goal_percentage_complete { get; set; }
        public string goal_target { get; set; }
        public string goal_under_funded { get; set; }
        public string overspending_affects_buffer { get; set; }
        public Amount payment_average { get; set; }
        public Amount payment_previous_month { get; set; }
        public Amount spent_average { get; set; }
        public Amount spent_previous_month { get; set; }
        public Amount unbudgeted_cash_outflows { get; set; }
        public Amount unbudgeted_credit_outflows { get; set; }
        public Amount upcoming_transactions { get; set; }
        public string upcoming_transactions_count { get; set; }
        public Amount positive_cash_outflows { get; set; }
    }
}