using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace GeneralEntities.ExtendedDateTime
{
	/// <summary>
	/// Конвертер  для DateTimeEx в JSON через Newton сериализатор
	/// </summary>
	public class ExtendedDateTimeJSONConverter : JsonConverter<DateTimeEx>
	{
		public override void WriteJson(JsonWriter writer, DateTimeEx value, JsonSerializer serializer)
		{
			writer.WriteValue(value.ToString());
		}

		public override DateTimeEx ReadJson(JsonReader reader, Type objectType, DateTimeEx existingValue, bool hasExistingValue, JsonSerializer serializer)
		{
			if (reader.Value == null)
			{
				return null;
			}

			switch (reader.TokenType)
			{
				case JsonToken.Date:
					return new DateTimeEx((DateTime)reader.Value);
				case JsonToken.String:
					return new DateTimeEx((string)reader.Value);
			}

			throw new SerializationException("Unknown JsonToken type");
		}
	}
}