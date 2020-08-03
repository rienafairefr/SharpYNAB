using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SharpYNAB.Contracts;
using SharpYNAB.Schema.Budget;
using SharpYNAB.Schema.Catalog;
using SharpYNAB.Schema.Models;
using Xunit;

namespace SharpYNAB.Tests
{
    public class MockConnection : IConnection
    {
        public class Request
        {
            public object Data { get; set; }
            public string Opname { get; set; }
        }

        public List<Request> Requests = new List<Request>();
        public async Task InitSession()
        {
            return;
        }

        public async Task<string> Dorequest(object data, string opname)
        {
            Requests.Add(new Request
            {
                Data = data,
                Opname = opname
            });
            return JsonConvert.SerializeObject(new Dictionary<string,object>
            {
                ["server_knowledge_of_device"] = 0,
                ["current_server_knowledge"] = 0,
                ["error"] = new ErrorData{Id=null},
                ["changed_entities"] = new Dictionary<string,object>()
            });
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
            client.BudgetVersion = new BudgetVersion();
            client.BudgetClient.ResetChanged();
            var addedTransaction = new Transaction
            {
                Amount = 12,
                Date = DateTime.Now
            };
            client.Budget.Transactions.Add(addedTransaction);
            client.Push(1);
            
            Assert.Equal(2, connection.Requests.Count);
            Assert.Equal("syncCatalogData", connection.Requests[0].Opname);
            Assert.Equal("syncBudgetData", connection.Requests[1].Opname);


            var cchangedEntities = (connection.Requests[0].Data as CatalogData)?.Changed;
            Assert.NotNull(cchangedEntities);
            Assert.Equal(0, cchangedEntities.Size);
            var bchangedEntities = (connection.Requests[1].Data as BudgetData)?.Changed;
            Assert.NotNull(bchangedEntities);
            Assert.Equal(1, bchangedEntities.Size);
            Assert.Equal(1, bchangedEntities.Transactions.Count);
            Assert.Equal(addedTransaction, bchangedEntities.Transactions[0]);
        }
    }
}
