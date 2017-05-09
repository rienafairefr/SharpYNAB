// ReSharper disable InconsistentNaming
namespace SharpnYNAB.Schema.Budget
{
    public class PayeeLocation:Entity
    {
        public Payee entities_payee { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
    }
}