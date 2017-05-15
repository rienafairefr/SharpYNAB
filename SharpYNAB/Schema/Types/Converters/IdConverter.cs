using System;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SharpYNAB.Schema.Types.Converters
{
    public class IdConverter : JsonConverter
    {
        public Regex RegexUuid = new Regex("[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}");
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is Guid)
            {
                writer.WriteValue(((Guid) value).ToString());
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var token = JToken.Load(reader).ToObject<string>();
            try
            {
                return Guid.Parse(token);
            }
            catch (FormatException)
            {
                var match = RegexUuid.Match(token);
                return Guid.Parse(match.Value);
            }
            catch (ArgumentNullException)
            {
                return null;
            }
        }

        public override bool CanConvert(Type objectType)
        {
            return typeof(Guid) == objectType;
        }
    }
}