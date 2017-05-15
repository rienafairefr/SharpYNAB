using System.Threading.Tasks;

namespace SharpYNAB.Schema.Contracts
{
    public interface IRootObjClient
    {
        Task Sync();
        Task Push();
    }
}