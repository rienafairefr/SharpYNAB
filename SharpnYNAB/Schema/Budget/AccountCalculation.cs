using System;
using SharpnYNAB.Schema.Types;
// ReSharper disable InconsistentNaming

namespace SharpnYNAB.Schema.Budget
{
    public class AccountCalculation : Entity
    {
        public Amount cleared_balance { get; set; }
        public Account entities_account { get; set; }
        public Guid entities_account_id { get; set; }
        public string error_count { get; set; }
        public string info_count { get; set; }
        public string transaction_count { get; set; }
        public Amount uncleared_balance { get; set; }
        public string warning_count { get; set; }
    }
}