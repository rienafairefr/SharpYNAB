using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SharpYNAB.Contracts;
using SharpYNAB.Schema.Budget;
using SharpYNAB.Schema.Roots;
using Xunit;

namespace SharpYNAB.Tests
{
    public class MockConnection : IConnection
    {
        public class Request
        {
            public Dictionary<string, object> Dict { get; set; }
            public string Opname { get; set; }
        }

        public List<Request> Requests = new List<Request>();
        public async Task init_session()
        {
            return;
        }

        public async Task<string> Dorequest(Dictionary<string, object> requestDict, string opname)
        {
            Requests.Add(new Request
            {
                Dict = requestDict,
                Opname = opname
            });
            return "";
        }

        public string UserId { get; set; }
    }
    public class MockPush
    {
        [Fact]
        public void MockPushMethod()
        {
            var args = Utils.GetTestArgs();
            var connection = new MockConnection();
            args.Connection = connection;
            var client = ClientFactory.CreateClient(args);
            client.Budget.Transactions.Add(new Transaction
            {
                Amount=12,
                Date=DateTime.Now
            });
            client.Push(1);
            Assert.Equal(1, connection.Requests.Count);
            Assert.Equal("syncBudgetData", connection.Requests[0].Opname);
            var dict = connection.Requests[0].Dict;
            var changedEntities = (Dictionary<string, object>) dict["changed_entities"];
        }
    }
}
