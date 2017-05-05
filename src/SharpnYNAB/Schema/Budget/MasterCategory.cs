namespace SharpnYNAB.Schema.Budget
{
    public class MasterCategory
    {
        public bool deletable { get; set; } = true;
        public string internal_name { get; set; }
        public bool is_hidden { get; set; } = false;
        public string name { get; set; }
        public string note { get; set; }
        public string sortable_index { get; set; }
    }
}