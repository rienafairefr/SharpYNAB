using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace SharpYNAB.Schema.Types
{
    [ComplexType]
    public class CurrencyFormat
    {
        [JsonProperty("display_symbol")]
        public bool DisplaySymbol { get; set; }
        [JsonProperty("iso_code")]
        public string IsoCode { get; set; }
        [JsonProperty("symbol_first")]
        public bool SymbolFirst { get; set; }
        [JsonProperty("currency_symbol")]
        public string CurrencySymbol { get; set; }
        [JsonProperty("decimal_digits")]
        public int DecimalDigits { get; set; }
        [JsonProperty("decimal_separator")]
        public string DecimalSeparator { get; set; }
        [JsonProperty("group_separator")]
        public string GroupSeparator { get; set; }
        [JsonProperty("example_format")]
        public string ExampleFormat { get; set; }

        protected bool Equals(CurrencyFormat other)
        {
            return DisplaySymbol == other.DisplaySymbol && string.Equals(IsoCode, other.IsoCode) && SymbolFirst == other.SymbolFirst && string.Equals(CurrencySymbol, other.CurrencySymbol) && DecimalDigits == other.DecimalDigits && string.Equals(DecimalSeparator, other.DecimalSeparator) && string.Equals(GroupSeparator, other.GroupSeparator) && string.Equals(ExampleFormat, other.ExampleFormat);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((CurrencyFormat) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = DisplaySymbol.GetHashCode();
                hashCode = (hashCode * 397) ^ (IsoCode != null ? IsoCode.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ SymbolFirst.GetHashCode();
                hashCode = (hashCode * 397) ^ (CurrencySymbol != null ? CurrencySymbol.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ DecimalDigits;
                hashCode = (hashCode * 397) ^ (DecimalSeparator != null ? DecimalSeparator.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (GroupSeparator != null ? GroupSeparator.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (ExampleFormat != null ? ExampleFormat.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}
