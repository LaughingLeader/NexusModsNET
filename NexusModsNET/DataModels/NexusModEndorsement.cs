namespace NexusModsNET.DataModels;

public class NexusModEndorsement
{
	[JsonPropertyName("endorse_status")]
	public string EndorseStatus { get; set; }

	[JsonPropertyName("timestamp")]
	[JsonConverter(typeof(UnixToNullableDateTimeConverter))]
	public DateTimeOffset? DateTime { get; set; }

	[JsonPropertyName("version")]
	public string Version { get; set; }
}
