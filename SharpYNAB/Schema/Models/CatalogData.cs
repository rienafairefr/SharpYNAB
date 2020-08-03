using Newtonsoft.Json;

namespace SharpYNAB.Schema.Models
{
    public class CatalogData : ClientData<Roots.Catalog>
    {
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}