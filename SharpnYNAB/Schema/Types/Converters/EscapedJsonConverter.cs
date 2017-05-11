using System;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SharpnYNAB.Schema.Types.Converters
{
    public class EscapedJsonConverter<T> : JsonConverter {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is T)
            {
                writer.WriteValue(Regex.Escape(JsonConvert.SerializeObject(value)));
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var token = JToken.Load(reader);
            var data = token.ToObject<string>();
            var unescaped = Regex.Unescape(data);
            return JsonConvert.DeserializeObject<T>(unescaped);
        }

        public override bool CanConvert(Type objectType)
        {
            return typeof(T) == objectType;
        }
    }
}