using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SharpnYNAB.Schema.Types.Converters
{
    public class AmountConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var token = JToken.Load(reader);
            var data = token.ToObject<string>();
            return null;
        }

        public override bool CanConvert(Type objectType)
        {
            return typeof(Amount) == objectType;
        }
    }
}