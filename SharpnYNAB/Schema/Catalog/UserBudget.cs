// ReSharper disable InconsistentNaming

using System;
using SharpnYNAB.Schema.Types;

namespace SharpnYNAB.Schema.Catalog
{
    public class UserBudget : Entity
    {
        public CatalogBudget budget { get; set; }
        public Guid budget_id { get; set; }
        public User user { get; set; }
        public Guid user_id { get; set; }
        public int permissions { get; set; }
    }
}