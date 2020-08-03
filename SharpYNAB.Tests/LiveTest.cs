using System;
using System.Linq;
using SharpYNAB.Schema;
using SharpYNAB.Schema.Budget;
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

        Client Client { get; set; }

        public void Reload()
        {
            var args = Utils.GetTestArgs();
            args.BudgetName = "Test Budget - Dont Remove";
            Client = ClientFactory.CreateClient(args);
            Client.Sync();
        }

        [Fact]
        public void AddDeleteTransaction()
        {
            Reload();
            var account = Client.Budget.Accounts.First();
            var transaction = new Transaction
            {
                Amount = 1,
                Cleared = "Uncleared",
                Date = DateTime.Now,
                EntitiesAccount = account,
            };
            Client.AddTransaction(transaction);
            Reload();
            Assert.Contains(transaction,Client.Budget.Transactions);
            Client.DeleteTransaction(transaction);
            Reload();
            Assert.DoesNotContain(transaction, Client.Budget.Transactions);
        }
    }
}
