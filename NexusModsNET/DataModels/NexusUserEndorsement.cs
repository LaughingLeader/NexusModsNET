namespace NexusModsNET.DataModels;

public class NexusUserEndorsement
{
	[JsonPropertyName("mod_id")]
	public long ModId { get; set; }

	[JsonPropertyName("domain_name")]
	public string DomainName { get; set; }

	[JsonPropertyName("date")]
	[JsonConverter(typeof(UnixToNullableDateTimeConverter))]
	public DateTimeOffset Date { get; set; }

	[JsonPropertyName("version")]
	public string Version { get; set; }

	[JsonPropertyName("status")]
	public string Status { get; set; }
}
