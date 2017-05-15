using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharpYNAB.Schema.Types
{
    [ComplexType]
    public class Date
    {
        public DateTime Value { get; set; }

        public Date(DateTime value)
        {
            Value = value;
        }

        public static implicit operator Date(DateTime d)
        {
            return new Date(d);
        }

        protected bool Equals(Date other)
        {
            return Value.Equals(other.Value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Date) obj);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
}
