using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SharpnYNAB.Schema.Types;
// ReSharper disable InconsistentNaming

namespace SharpnYNAB.Schema.Budget
{
    public class MonthlySubCategoryBudget : Entity
    {
        public Amount budgeted { get; set; }
        public MonthlyBudget entities_monthly_budget { get; set; }
        public Guid entities_monthly_budget_id { get; set; }
        public SubCategory entities_subcategory { get; set; }
        public Guid entities_subcategory_id { get; set; }
        public string note { get; set; }
        public string overspending_handling { get; set; }
    }
}