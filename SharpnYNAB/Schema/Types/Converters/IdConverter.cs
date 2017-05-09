using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SharpnYNAB.Schema.Types.Converters
{
    public class IdConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var token = JToken.Load(reader);
            return Guid.Parse(token.ToObject<string>());
        }

        public override bool CanConvert(Type objectType)
        {
            return typeof(Guid) == objectType;
        }
    }
}