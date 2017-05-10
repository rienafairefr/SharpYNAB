using System;
using SharpnYNAB.Schema.Types;
// ReSharper disable InconsistentNaming

namespace SharpnYNAB.Schema.Budget
{
    public class ScheduledSubTransaction:Entity
    {
        public Amount amount { get; set; }
        public Payee entities_payee { get; set; }
        public Guid entities_payee_id { get; set; }
        public Transaction entities_scheduled_transaction { get; set; }

        public SubCategory entities_subcategory { get; set; }
        public Guid entities_subcategory_id { get; set; }
        public string memo { get; set; }
        public int sortable_index { get; set; } = 0;
        public Account transfer_account { get; set; }
        public Guid transfer_account_id { get; set; }
    }
}