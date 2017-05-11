using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpnYNAB.Schema;
using SharpnYNAB.Schema.Budget;
using Xunit;

namespace SharpnYNAB.Tests
{
    public class ChangedEntitiesTests
    {
        [Fact]
        public void AddElement()
        {
            var client = new Client();
            var acc = new Account();
            client.budget.be_accounts.Add(acc);
            var changed = client.BudgetClient.Changed;
            Assert.Equal(1, changed.Size);
            Assert.Equal(acc, changed.be_accounts[0]);
        }

        [Fact]
        public void RemoveElement()
        {
            var client = new Client();
            var acc = new Account();
            client.budget.be_accounts.Add(acc);
            client.BudgetClient.ResetChanged();

            client.budget.be_accounts.Remove(acc);
            var changed = client.BudgetClient.Changed;
            Assert.Equal(1, changed.Size);
            Assert.Equal(true, changed.be_accounts[0].is_tombstone);
            Assert.Equal(acc, changed.be_accounts[0]);
        }

        [Fact]
        public void ChangeElement()
        {
            var client = new Client();
            var acc = new Account();
            client.budget.be_accounts.Add(acc);
            client.BudgetClient.ResetChanged();

            acc.account_name = "BLABLA";

            var changed = client.BudgetClient.Changed;
            Assert.Equal(1, changed.Size);
            Assert.Equal("BLABLA", changed.be_accounts[0].account_name);
            Assert.Equal(acc, changed.be_accounts[0]);
        }

        [Fact]
        public void ChangeTwiceElement()
        {
            var client = new Client();
            var acc = new Account();
            client.budget.be_accounts.Add(acc);
            client.BudgetClient.ResetChanged();

            acc.account_name = "BLABLA";
            acc.account_name = "TURLUTUTU";

            var changed = client.BudgetClient.Changed;
            Assert.Equal(1, changed.Size);
            Assert.Equal("TURLUTUTU", changed.be_accounts[0].account_name);
            Assert.Equal(acc, changed.be_accounts[0]);
        }

        [Fact]
        public void ReplaceElement()
        {
            var client = new Client();
            var acc = new Account
            {
                account_name = "FIRST"
            };
            var acc2 = new Account
            {
                account_name = "SECOND"
            };
            client.budget.be_accounts.Add(acc);
            client.BudgetClient.ResetChanged();

            client.budget.be_accounts[0] = acc2;

            var changed = client.BudgetClient.Changed;
            Assert.Equal(2, changed.Size);
            var names = changed.be_accounts.Select(o => o.account_name).ToList();
            Assert.Contains("FIRST", names);
            Assert.Contains("SECOND", names);

            foreach (var obj in changed.be_accounts)
            {
                if (obj.account_name == "FIRST")
                {
                    Assert.Equal(true, obj.is_tombstone);
                }
                if (obj.account_name == "SECOND")
                {
                    Assert.Equal(false, obj.is_tombstone);
                }
            }
        }
    }
}

