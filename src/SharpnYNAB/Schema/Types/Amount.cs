using System;

namespace SharpnYNAB.Schema.Types
{
    public class Amount
    {
        public static implicit operator Amount(int v)
        {
            throw new NotImplementedException();
        }
    }
}