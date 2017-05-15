using System;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SharpYNAB.Schema.Types.Converters
{
    public class DateConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (!(value is Date)) return;

            writer.WriteValue(((Date) value).Value.ToString("yyyy-MM-dd"));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var token = JToken.Load(reader);
            var data = token.ToObject<string>();
            DateTime date;
            var result = DateTime.TryParseExact(data, "yyyy-MM-dd", 
                CultureInfo.InvariantCulture,
                DateTimeStyles.None, out date);
            return result ? (object) new Date(date.Date) : null;
        }

        public override bool CanConvert(Type objectType)
        {
            return typeof(Date) == objectType;
        }
    }
}