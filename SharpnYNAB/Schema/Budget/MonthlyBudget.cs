using SharpnYNAB.Schema.Types;
// ReSharper disable InconsistentNaming

namespace SharpnYNAB.Schema.Budget
{
    public class MonthlyBudget:Entity
    {
        public Date month { get; set; }
        public string note { get; set; }
    }
}