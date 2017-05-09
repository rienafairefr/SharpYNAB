using System;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SharpnYNAB.Schema.Types.Converters
{
    public class DateConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var token = JToken.Load(reader);
            var data = token.ToObject<string>();
            DateTime date;
            var result = DateTime.TryParseExact(data, "yyyy-MM-dd", 
                CultureInfo.InvariantCulture,
                DateTimeStyles.None, out date);
            if (result) return new Date{DateTime=date};
            return null;
        }

        public override bool CanConvert(Type objectType)
        {
            return typeof(Date) == objectType;
        }
    }
}