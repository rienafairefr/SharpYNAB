using System.Collections.Generic;
using SharpnYNAB.Schema.Types;

// ReSharper disable InconsistentNaming

namespace SharpnYNAB.Schema.Catalog
{
    public class User : Entity
    {
        public string username { get; set; }
        public Date trial_expires_on { get; set; }
        public string email { get; set; }
        public List<string> feature_flags { get; set; }
        public int sign_in_count { get; set; }
        public bool is_subscribed { get; set; }
    }
}