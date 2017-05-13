using System.Collections.ObjectModel;
using Newtonsoft.Json;
using SharpnYNAB.Schema.Budget;
using SharpnYNAB.Schema.Types;

// ReSharper disable InconsistentNaming

namespace SharpnYNAB.Schema.Roots
{
    public class Budget : RootObj
    {
        private Date _lastMonth;
        private Date _firstMonth;
        [JsonProperty("be_transactions")]
        public ObservableCollection<Transaction> Transactions { get; set; } = new ObservableCollection<Transaction>();
         [JsonProperty("be_subtransactions")]
        public ObservableCollection<Subtransaction> Subtransactions { get; set; } = new ObservableCollection<Subtransaction>();

        [JsonProperty("last_month")]
        public Date LastMonth
        {
            get => _lastMonth;
            set { _lastMonth = value; OnPropertyChanged(); }
        }

        [JsonProperty("first_month")]
        public Date FirstMonth
        {
            get => _firstMonth;
            set { _firstMonth = value; OnPropertyChanged(); }
        }

        public override int Size => Transactions.Count + Subtransactions.Count;
    }
}