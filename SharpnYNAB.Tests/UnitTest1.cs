using System.IO;
using System.Threading.Tasks;
using Xunit;
using Newtonsoft.Json;

namespace SharpnYNAB.Tests
{
    public class UnitTest1
    {
        [Fact]
        public async void TestMethod1()
        {
            var args = JsonConvert.DeserializeObject<Args>(File.ReadAllText("ynab.conf"));
            var client = ClientFactory.CreateClient(args);
            await client.Sync();
        }
    }
}
