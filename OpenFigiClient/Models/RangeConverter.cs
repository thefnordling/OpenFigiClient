using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class RangeConverter<T> : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(Range<T>));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var item = serializer.Deserialize<T[]>(reader);
            var range = new Range<T>(item[0], item[1]);
            return range;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (typeof(T) == typeof(DateTime?))
            {
                var item = value as Range<DateTime?>;
                var from = item.From.HasValue ? item.From.Value.ToString("yyyy-MM-dd") : null;
                var to = item.To.HasValue ? item.To.Value.ToString("yyyy-MM-dd") : null;
                var array = new string[] { from, to };
                serializer.Serialize(writer, array);
            }
            else
            {
                var item = value as Range<T>;
                var array = new T[] { item.From, item.To };
                serializer.Serialize(writer, array);
            }
        }
    }
}
