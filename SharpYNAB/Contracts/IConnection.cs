using System.Collections.Generic;
using System.Threading.Tasks;
using SharpYNAB.Schema.Clients;

namespace SharpYNAB.Contracts
{
    public interface IConnection
    {
        Task InitSession();
        Task<string> Dorequest(object requestData, string opname);
        string UserId { get; set; }
    }
}