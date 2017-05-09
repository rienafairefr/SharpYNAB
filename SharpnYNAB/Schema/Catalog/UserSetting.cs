// ReSharper disable InconsistentNaming

using System;
using SharpnYNAB.Schema.Types;

namespace SharpnYNAB.Schema.Catalog
{
    public class UserSetting:Entity
    {
        public string setting_name { get; set; }
        public User user { get; set; }
        public Guid user_id { get; set; }
        public string setting_value { get; set; }
    }
}
