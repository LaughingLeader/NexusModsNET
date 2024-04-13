namespace NexusModsNET.DataModels;

public class NexusModUpdate
{
	[JsonPropertyName("mod_id")]
	public long ModId { get; set; }

	[JsonPropertyName("latest_file_update")]
	[JsonConverter(typeof(UnixToNullableDateTimeConverter))]
	public DateTimeOffset LatestFileUpdate { get; set; }

	[JsonPropertyName("latest_mod_activity")]
	[JsonConverter(typeof(UnixToNullableDateTimeConverter))]
	public DateTimeOffset LatestModActivity { get; set; }
}
