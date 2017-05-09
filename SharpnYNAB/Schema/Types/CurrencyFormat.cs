// ReSharper disable InconsistentNaming

namespace SharpnYNAB.Schema.Types
{
    public class CurrencyFormat
    {
        public bool display_symbol { get; set; }
        public string iso_code { get; set; }
        public bool symbol_first { get; set; }
        public string currency_symbol { get; set; }
        public int decimal_digits { get; set; }
        public string decimal_separator { get; set; }
        public string group_separator { get; set; }
        public string example_format { get; set; }
    }
}
