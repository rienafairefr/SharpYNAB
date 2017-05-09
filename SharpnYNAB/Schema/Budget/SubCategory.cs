using SharpnYNAB.Schema.Types;

// ReSharper disable InconsistentNaming

namespace SharpnYNAB.Schema.Budget
{
    public class SubCategory:Entity
    {
        public Account entities_account { get; set; }
        public MasterCategory entities_master_category { get; set; }
        public string goal_creation_month { get; set; }
        public string goal_type { get; set; }
        public string internal_name { get; set; }
        public bool is_hidden { get; set; } = false;
        public string monthly_funding { get; set; }
        public string name { get; set; }
        public string note { get; set; }
        public int sortable_index { get; set; } = 0;
        public Amount target_balance { get; set; }
        public string target_balance_month { get; set; }
        public string type { get; set; }
    }
}
