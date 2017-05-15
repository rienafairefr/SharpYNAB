using System.Threading.Tasks;

namespace SharpYNAB.Schema
{
    public interface IRootObjClient
    {
        Task Sync();
        Task Push();
    }
}