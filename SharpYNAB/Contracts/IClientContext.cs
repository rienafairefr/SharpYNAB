using Microsoft.EntityFrameworkCore;
using SharpYNAB.Schema;

namespace SharpYNAB.Contracts
{
    public interface IClientContext
    {
        DbSet<Client> Clients { get; set; }
    }
}