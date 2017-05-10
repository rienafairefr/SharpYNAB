using System;
// ReSharper disable InconsistentNaming

namespace SharpnYNAB.Schema.Budget
{
    public class UpcomingInstance:Entity
    {
        public ScheduledTransaction scheduledtransaction { get; set; }
        public Guid scheduledtransaction_id { get; set; }
    }
}