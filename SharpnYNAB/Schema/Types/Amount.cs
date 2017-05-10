using System;

namespace SharpnYNAB.Schema.Types
{
    public class Amount
    {
        public decimal Value;

        public Amount(decimal value)
        {
            Value = value;
        }

        public static implicit operator Amount(int v)
        {
            return new Amount(v);
        }
    }
}