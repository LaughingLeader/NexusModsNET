namespace NexusModsNET.Internals.Converters;

internal class NullableLongConverter : JsonConverter<long?>
{
	public override long? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		//Is this a valid `reader.Value is bool` replacement?
		if (reader.TokenType == JsonTokenType.True || reader.TokenType == JsonTokenType.False || reader.TokenType == JsonTokenType.Null)
		{
			return null;
		}
		try
		{
			return reader.GetInt64();
		}
		catch { }
		return null;
	}

	// write is out of scope, but this could be implemented via writer.ToUnixTimeMilliseconds/WriteNullValue
	public override void Write(Utf8JsonWriter writer, long? value, JsonSerializerOptions options)
	{
		if(value == null)
		{
			writer.WriteNullValue();
		}
		else
		{
			writer.WriteNumberValue(value.Value);
		}
	}
}
