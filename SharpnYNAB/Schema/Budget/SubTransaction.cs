using SharpnYNAB.Schema.Types;
// ReSharper disable InconsistentNaming

namespace SharpnYNAB.Schema.Budget
{
    public class SubTransaction:Entity
    {
        public Amount amount { get; set; }
        public Amount cash_amount { get; set; }
        public string heck_number { get; set; }
        public Amount credit_amount { get; set; }
        public Payee entities_payee { get; set; }
        public SubCategory entities_subcategory { get; set; }
        public Transaction entities_transaction { get; set; }
        public string memo { get; set; }
        public int sortable_index { get; set; } = 0;
        public int subcategory_credit_amount_preceding { get; set; } = 0;
        public Account transfer_account { get; set; }
        public Transaction transfer_transaction { get; set; }
    }
}