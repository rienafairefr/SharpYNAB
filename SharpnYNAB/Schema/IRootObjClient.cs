using System.Threading.Tasks;

namespace SharpnYNAB.Schema
{
    public interface IRootObjClient
    {
        Task Sync();
        Task Push();
    }
}