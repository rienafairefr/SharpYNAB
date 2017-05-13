using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using SharpnYNAB.Schema.Budget;

// ReSharper disable InconsistentNaming

namespace SharpnYNAB.Schema
{
    public class Client
    {
        public Roots.Budget budget { get; set; }
        public string budget_name { get; set; }
        public int starting_device_knowledge { get; set; }
        public int ending_device_knowledge { get; set; }
        public string UserId => Connection.UserId;

        [NotMapped]
        public BudgetClient BudgetClient { get; set; }
        [NotMapped]
        public IConnection Connection { get; set; }

        public Client()
        {
            budget = new Roots.Budget();
            BudgetClient = new BudgetClient(this);
            BudgetClient.ResetChanged();
        }


        public Task Sync()
        {
            throw new NotImplementedException();
        }
    }

    public class WrongPushException : Exception
    {
    }
}
