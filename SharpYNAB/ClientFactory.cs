using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SharpYNAB.Contracts;
using SharpYNAB.Schema;
using SharpYNAB.Schema.Budget;
using SharpYNAB.Schema.Catalog;


namespace SharpYNAB
{
    public class ClientContext : DbContext, IClientContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("SharpYNAB");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transaction>().HasOne(s => s.MatchedTransaction).WithMany();
            modelBuilder.Entity<Transaction>().HasOne(s => s.TransferSubtransaction).WithOne(s => s.TransferTransaction);
            modelBuilder.Entity<Transaction>().HasOne(s => s.TransferTransaction).WithMany();
            modelBuilder.Entity<Subtransaction>().HasOne(s => s.EntitiesTransaction).WithMany(s => s.Subtransactions);
            modelBuilder.Entity<User>().Ignore(s => s.FeatureFlags);
        }
        public DbSet<Client> Clients { get; set; }
    }

    public class ClientFactory
    {
        public static Client CreateClient(Args args)
        {
            var factory = new CustomClientFactory<ClientContext>();
            return factory.CreateClient(args);
        }
    }

    public class CustomClientFactory<T> where T : DbContext, IClientContext, new()
    {
        public CustomClientFactory()
        {
            using (var context = new T())
            {
                context.Database.EnsureCreated();
            }
        }
        public Client CreateClient(Args args)
        {
            if (args.BudgetName == null)
            {
                throw new NoBudgetNameException();
            }

            if (args.Connection == null)
            {
                args.Connection = new Connection(args.Email, args.Password);
                Task.Run(()=>args.Connection.init_session()).Wait();
            }
            var clientId = args.Connection.UserId;
            using (var db = new T())
            {
                var previousClient = db.Clients.SingleOrDefault(x => x.UserId == clientId);
                if (previousClient != null) return previousClient;
                var client = new Client
                {
                    BudgetName = args.BudgetName,
                    Connection = args.Connection
                };
                return client;
            }
        }
    }

    public class NoBudgetNameException : Exception
    {
    }
}
