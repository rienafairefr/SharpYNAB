// ReSharper disable InconsistentNaming
namespace SharpnYNAB.Schema.Budget
{
    public class MasterCategory:Entity
    {
        public bool deletable { get; set; } = true;
        public string internal_name { get; set; }
        public bool? is_hidden { get; set; } = false;
        public string name { get; set; }
        public string note { get; set; }
        public int sortable_index { get; set; }
    }
}