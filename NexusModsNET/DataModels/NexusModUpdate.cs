namespace NexusModsNET.DataModels;

public class NexusModUpdate
{
	[JsonPropertyName("mod_id")]
	public long ModId { get; set; }

	[JsonPropertyName("latest_file_update")]
	[JsonConverter(typeof(UnixToNullableDateTimeOffsetConverter))]
	public DateTimeOffset LatestFileUpdate { get; set; }

	[JsonPropertyName("latest_mod_activity")]
	[JsonConverter(typeof(UnixToNullableDateTimeOffsetConverter))]
	public DateTimeOffset LatestModActivity { get; set; }
}
