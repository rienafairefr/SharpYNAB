using SharpnYNAB.Schema.Types;
// ReSharper disable InconsistentNaming

namespace SharpnYNAB.Schema.Budget
{
    public class Payee:Entity
    {
        public Amount auto_fill_amount { get; set; }
        public string auto_fill_amount_enabled { get; set; }
        public string auto_fill_memo { get; set; }
        public string auto_fill_memo_enabled { get; set; }
        public string auto_fill_subcategory_enabled { get; set; }

        public SubCategory auto_fill_subcategory { get; set; }
        public bool enabled { get; set; }
        public Account entities_account { get; set; }
        public string internal_name { get; set; }
        public string name { get; set; }
        public string rename_on_import_enabled { get; set; }
    }
}