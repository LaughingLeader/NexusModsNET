namespace NexusModsNET.Internals.Converters;

internal class GameApprovedDateConverter : UnixToNullableDateTimeOffsetConverter
{
	public override DateTimeOffset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		try
		{
			if (reader.TryGetInt64(out var time))
			{
				if (time < 2) return DateTimeOffset.MinValue;

				if (IsFormatInSeconds == true || IsFormatInSeconds == null && time > _unixMinSeconds && time < _unixMaxSeconds)
					return DateTimeOffset.FromUnixTimeSeconds(time).LocalDateTime;
				return DateTimeOffset.FromUnixTimeMilliseconds(time).LocalDateTime;
			}
		}
		catch { }

		return DateTimeOffset.MinValue;
	}
}
