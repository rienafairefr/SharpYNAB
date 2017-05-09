using System.Collections.Generic;
using SharpnYNAB.Schema.Types;
// ReSharper disable InconsistentNaming

namespace SharpnYNAB.Schema.Budget
{
    public class ScheduledTransaction:Entity
    {
        public Amount amount { get; set; }
        public Date date { get; set; }
        public Account entities_account { get; set; }
        public Payee entities_payee { get; set; }
        public SubCategory entities_subcategory { get; set; }
        public Transaction transaction { get; set; }
        public string flag { get; set; }
        public string frequency { get; set; }
        public string memo { get; set; }
        public Account transfer_account { get; set; }

        public List<UpcomingInstance> upcoming_instances { get; set; }
    }
}