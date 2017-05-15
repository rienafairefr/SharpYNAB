using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpYNAB.Schema;
using SharpYNAB.Schema.Budget;
using Xunit;

namespace SharpYNAB.Tests
{
    public class ChangedEntitiesTests
    {
        [Fact]
        public void AddElement()
        {
            var client = new Client();
            var acc = new Account();
            client.Budget.Accounts.Add(acc);
            var changed = client.BudgetClient.Changed;
            Assert.Equal(1, changed.Size);
            Assert.Equal(acc, changed.Accounts[0]);
        }

        [Fact]
        public void RemoveElement()
        {
            var client = new Client();
            var acc = new Account();
            client.Budget.Accounts.Add(acc);
            client.BudgetClient.ResetChanged();

            client.Budget.Accounts.Remove(acc);
            var changed = client.BudgetClient.Changed;
            Assert.Equal(1, changed.Size);
            Assert.Equal(true, changed.Accounts[0].is_tombstone);
            Assert.Equal(acc, changed.Accounts[0]);
        }

        [Fact]
        public void ChangeElement()
        {
            var client = new Client();
            var acc = new Account();
            client.Budget.Accounts.Add(acc);
            client.BudgetClient.ResetChanged();

            acc.AccountName = "BLABLA";

            var changed = client.BudgetClient.Changed;
            Assert.Equal(1, changed.Size);
            Assert.Equal("BLABLA", changed.Accounts[0].AccountName);
            Assert.Equal(acc, changed.Accounts[0]);
        }

        [Fact]
        public void ChangeTwiceElement()
        {
            var client = new Client();
            var acc = new Account();
            client.Budget.Accounts.Add(acc);
            client.BudgetClient.ResetChanged();

            acc.AccountName = "BLABLA";
            acc.AccountName = "TURLUTUTU";

            var changed = client.BudgetClient.Changed;
            Assert.Equal(1, changed.Size);
            Assert.Equal("TURLUTUTU", changed.Accounts[0].AccountName);
            Assert.Equal(acc, changed.Accounts[0]);
        }

        [Fact]
        public void ReplaceElement()
        {
            var client = new Client();
            var acc = new Account
            {
                AccountName = "FIRST"
            };
            var acc2 = new Account
            {
                AccountName = "SECOND"
            };
            client.Budget.Accounts.Add(acc);
            client.BudgetClient.ResetChanged();

            client.Budget.Accounts[0] = acc2;

            var changed = client.BudgetClient.Changed;
            Assert.Equal(2, changed.Size);
            var names = changed.Accounts.Select(o => o.AccountName).ToList();
            Assert.Contains("FIRST", names);
            Assert.Contains("SECOND", names);

            foreach (var obj in changed.Accounts)
            {
                if (obj.AccountName == "FIRST")
                {
                    Assert.Equal(true, obj.is_tombstone);
                }
                if (obj.AccountName == "SECOND")
                {
                    Assert.Equal(false, obj.is_tombstone);
                }
            }
        }
    }
}

