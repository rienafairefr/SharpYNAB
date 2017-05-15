using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace SharpYNAB.Schema.Types
{
    [ComplexType]
    public class DateFormat
    {
        [JsonProperty("format")]
        public string Format { get; set; }

        protected bool Equals(DateFormat other)
        {
            return string.Equals(Format, other.Format);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((DateFormat) obj);
        }

        public override int GetHashCode()
        {
            return (Format != null ? Format.GetHashCode() : 0);
        }
    }
}
