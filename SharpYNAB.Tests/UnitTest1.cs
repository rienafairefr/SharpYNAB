using System.IO;
using System.Threading.Tasks;
using Xunit;
using Newtonsoft.Json;

namespace SharpYNAB.Tests
{
    public class UnitTest1
    {
        [Fact]
        public async void TestMethod1()
        {
            var args = Utils.GetTestArgs();
            var client = ClientFactory.CreateClient(args);
            await client.Sync();
        }
    }
}
