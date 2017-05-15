using System.Linq;
using Xunit;

namespace SharpYNAB.Tests
{
    public class LiveTest
    {
        [Fact]
        public void ApiScalingOk()
        {
            var args = Utils.GetTestArgs();
            args.BudgetName = "Test Budget - Dont Remove";
            var client = ClientFactory.CreateClient(args);
            client.Sync();
            var transaction = client.Budget.Transactions.FirstOrDefault(tr => tr.Memo == "TEST TRANSACTION");
            Assert.Equal(12.34, transaction?.Amount);
        }
    }
}
