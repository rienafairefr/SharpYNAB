using SharpnYNAB.Schema.Types;

namespace SharpnYNAB.Schema.Budget
{
    public class MonthlyAccountCalculation
    {
        public Amount cleared_balance { get; set; }
        public Account entities_account { get; set; }
        public string error_count { get; set; }
        public string info_count { get; set; }
        public string month { get; set; }
        public string transaction_count { get; set; }
        public Amount uncleared_balance { get; set; }
        public string warning_count { get; set; }
        public Amount rolling_balance { get; set; }
    }
}