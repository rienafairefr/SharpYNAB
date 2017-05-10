using System.IO;
using System.Threading.Tasks;
using Xunit;
using Newtonsoft.Json;

namespace SharpnYNAB.Tests
{
    public class Args
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string BudgetName { get; set; }
    }
    public class UnitTest1
    {
        [Fact]
        public async void TestMethod1()
        {
            Args args;
            using (var file = File.OpenText(("ynab.conf")))
            {
                var serializer = new JsonSerializer();
                args = (Args)serializer.Deserialize(file, typeof(Args));
            }
            var connection = new Connection(args.Email, args.Password);
            await connection.init_session();
            var client = new Schema.Client
            {
                Connection = connection,
                budget_name=args.BudgetName
            };
            await client.Sync();
        }
    }
}
