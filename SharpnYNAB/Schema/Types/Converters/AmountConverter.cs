using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SharpnYNAB.Schema.Types.Converters
{
    public class AmountConverter : JsonConverter
    {
        public const int ratio = 1000;
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(ratio * (int) value);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var token = JToken.Load(reader);
            try
            {
                var data = token.ToObject<decimal>();
                return new Amount(data / ratio);
            }
            catch (ArgumentException)
            {
                return null;
            }
        }

        public override bool CanConvert(Type objectType)
        {
            return typeof(Amount) == objectType;
        }
    }
}