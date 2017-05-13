using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SharpnYNAB.Schema;
using SharpnYNAB.Schema.Budget;


namespace SharpnYNAB
{
    public class Args
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string BudgetName { get; set; }
        public IConnection Connection { get; set; }
    }
    public class ClientContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("sqlite://:memory:");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountCalculation>()
                .HasOne(ac => ac.EntitiesAccount)
                .WithMany(b => b.AccountCalculations);
            modelBuilder.Entity<MonthlySubcategoryBudget>()
                .HasOne(a => a.EntitiesSubcategory)
                .WithOne(a => a.MonthlySubcategoryBudget);
        }
        public DbSet<Client> Clients { get; set; }
    }
    public class ClientFactory
    {
        public ClientFactory()
        {
            using (var context = new ClientContext())
            {
                context.Database.EnsureCreated();
            }
        }
        public async Task<Client> CreateClient(Args args)
        {
            if (args.BudgetName == null)
            {
                throw new NoBudgetNameException();
            }

            if (args.Connection == null)
            {
                args.Connection = new Connection(args.Email, args.Password);
                await args.Connection.init_session();
            }
            var clientId = args.Connection.UserId;
            using (var db = new ClientContext())
            {
                var previousClient = await db.Clients.SingleOrDefaultAsync(x => x.UserId == clientId);
                if (previousClient == null)
                {
                    var client = new Client
                    {
                        budget_name = args.BudgetName,
                        Connection = args.Connection
                    };
                    return client;
                }
                else
                {
                    return previousClient;
                }
            }
        }
    }

    public class NoBudgetNameException : Exception
    {
    }
}
