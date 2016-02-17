using Newtonsoft.Json;
using System;

namespace GeneralEntities.ExtendedDateTime
{
	/// <summary>
	/// Конвертер  для DateTimeEx в JSON через Newton сериализатор
	/// </summary>
	public class ExtendedDateTimeJSONConverter : JsonConverter
	{
		public override bool CanConvert(Type objectType)
		{
			return objectType == typeof(DateTimeEx);
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			if (reader.Value == null)
			{
				return null;
			}
			else
			{
				return new DateTimeEx(reader.Value as string);
			}
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			writer.WriteValue((value as DateTimeEx).ToString());
		}
	}
}