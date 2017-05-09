using System;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SharpnYNAB.Schema.Types.Converters
{
    public class CurrencyFormatConverter : JsonConverter {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var token = JToken.Load(reader);
            var data = token.ToObject<string>();
            var unescaped = Regex.Unescape(data);
            return JsonConvert.DeserializeObject<CurrencyFormat>(unescaped);
        }

        public override bool CanConvert(Type objectType)
        {
            return typeof(CurrencyFormat) == objectType;
        }
    }
}