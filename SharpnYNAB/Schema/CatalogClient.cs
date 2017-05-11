using System.Collections.Generic;

namespace SharpnYNAB.Schema
{
    public partial class CatalogClient : RootObjClient<Roots.Catalog>
    {
        public CatalogClient(Client client) : base(client,client.catalog) { }
        public override Dictionary<string, object> Extra => new Dictionary<string, object>()
        {
            ["user_id"] = Client.UserId
        };
        public override string opname => "syncCatalogData";
    }
}