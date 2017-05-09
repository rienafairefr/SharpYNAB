using System;
using SharpnYNAB.Schema.Types;

// ReSharper disable InconsistentNaming

namespace SharpnYNAB.Schema.Catalog
{
    
    public class BudgetVersion:Entity
    {
        public string date_format { get; set; }
        public DateTime last_accessed_on { get; set; }
        public CurrencyFormat currency_format { get; set; }
        public Guid budget_id { get; set; }
        public CatalogBudget budget { get; set; }
        public string version_name { get; set; }
        public string source { get; set; }
    }
}