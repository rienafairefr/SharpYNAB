using System.Collections.Generic;
using System.Threading.Tasks;

namespace SharpYNAB.Contracts
{
    public interface IConnection
    {
        Task init_session();
        Task<string> Dorequest(Dictionary<string, object> requestDict, string opname);
        string UserId { get; set; }
    }
}