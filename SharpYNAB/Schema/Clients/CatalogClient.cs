using SharpYNAB.Schema.Models;
using SharpYNAB.Schema.Models.Contracts;

namespace SharpYNAB.Schema.Clients
{
    public partial class CatalogClient : RootObjClient<Roots.Catalog>
    {
        public CatalogClient(Client client) : base(client,client.Catalog) { }

        public override string Opname => "syncCatalogData";
        public override IClientData<Roots.Catalog> GetClientData()
        {
            return new CatalogData
            {
                UserId = Client.UserId
            };
        }
    }
}