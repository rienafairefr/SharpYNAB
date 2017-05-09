using SharpnYNAB.Schema.Types;
// ReSharper disable InconsistentNaming

namespace SharpnYNAB.Schema.Budget
{
    public class Transaction:Entity
    {
        public bool accepted { get; set; } = true;
        public Amount amount { get; set; }
        public Amount cash_amount { get; set; }
        public string check_number { get; set; }
        public string cleared { get; set; } = "Uncleared";
        public Amount credit_amount { get; set; }
        public bool credit_amount_adjusted { get; set; }
        public Date date { get; set; }
        public Date date_entered_from_schedule { get; set; }
        public Account entities_account { get; set; }
        public Payee entities_payee { get; set; }
        public SubCategory entities_subcategory { get; set; }
        public ScheduledTransaction entities_scheduled_transaction { get; set; }
        public string flag { get; set; }
        public Date imported_date { get; set; }
        public string imported_payee { get; set; }
        public Transaction matched_transaction { get; set; }
        public string memo { get; set; }
        public string source { get; set; }
        public Amount subcategory_credit_amount_preceding { get; set; } = 0;
        public Account transfer_account { get; set; }
        public SubTransaction transfer_subtransaction { get; set; }
        public Transaction transfer_transaction { get; set; }
        public string ynab_id { get; set; }
    }
}