using System;
using Newtonsoft.Json;

namespace SharpYNAB.Schema.Models
{
    public class BudgetData:ClientData<Roots.Budget>
    {
        [JsonProperty("calculated_entities_included")]
        public bool CalculatedEntitiesIncluded { get; set; }
        [JsonProperty("budget_version_id")]
        public Guid BudgetVersionId { get; set; }
    }
}