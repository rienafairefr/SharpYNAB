
using System.ComponentModel.DataAnnotations.Schema;

namespace SharpYNAB.Schema.Types
{
    [ComplexType]
    public class Amount
    {
        protected bool Equals(Amount other)
        {
            return Value == other.Value;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Amount) obj);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public decimal Value { get; set; }

        public Amount(decimal value)
        {
            Value = value;
        }

        public static implicit operator Amount(int v)
        {
            return new Amount(v);
        }

        public static implicit operator Amount(decimal v)
        {
            return new Amount(v);
        }

        public static implicit operator Amount(double v)
        {
            return new Amount((decimal) v);
        }
    }
}