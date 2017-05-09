using System;
// ReSharper disable InconsistentNaming

namespace SharpnYNAB.Schema.Catalog
{
    public class CatalogBudget : Entity
    {
        public string budget_name { get; set; }
        public DateTime? created_at { get; set; }
    }
}