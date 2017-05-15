using System;

namespace SharpYNAB.Schema
{
    public static class Utils
    {
        public static string GenerateUuid()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
