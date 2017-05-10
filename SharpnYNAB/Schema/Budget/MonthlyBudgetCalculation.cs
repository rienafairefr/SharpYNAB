using System;
using SharpnYNAB.Schema.Types;
// ReSharper disable InconsistentNaming

namespace SharpnYNAB.Schema.Budget
{
    public class MonthlyBudgetCalculation:Entity
    {
        public Amount additional_to_be_budgeted { get; set; }
        public string age_of_money { get; set; }
        public string available_to_budget { get; set; }
        public string balance { get; set; }
        public string budgeted { get; set; }
        public string calculation_notes { get; set; }
        public Amount cash_outflows { get; set; }
        public Amount credit_outflows { get; set; }
        public Amount deferred_income { get; set; }
        public MonthlyBudget entities_monthly_budget { get; set; }
        public Guid entities_monthly_budget_id { get; set; }
        public Amount hidden_balance { get; set; }
        public Amount hidden_budgeted { get; set; }
        public Amount hidden_cash_outflows { get; set; }
        public Amount hidden_credit_outflows { get; set; }
        public Amount immediate_income { get; set; }
        public Amount over_spent { get; set; }
        public Amount previous_income { get; set; }
        public Amount uncategorized_balance { get; set; }
        public Amount uncategorized_cash_outflows { get; set; }
        public Amount uncategorized_credit_outflows { get; set; }
    }
}