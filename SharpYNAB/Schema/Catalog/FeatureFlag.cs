using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharpYNAB.Schema.Catalog
{
    public class FeatureFlag
    {
        public FeatureFlag(string value)
        {
            Value = value;
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Value { get; set; }

        public static implicit operator FeatureFlag(string value)
        {
            // While not technically a requirement; see below why this is done.
            if (value == null)
                return null;

            return new FeatureFlag(value);
        }
    }
}
