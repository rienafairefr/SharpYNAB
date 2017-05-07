using System;

namespace SharpnYNAB.Schema
{
    public static class Utils
    {
        public static string GenerateUuid()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
