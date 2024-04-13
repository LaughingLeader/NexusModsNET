namespace NexusModsNET.DataModels;

public class NexusUserTrackedMod
{
	[JsonPropertyName("mod_id")]
	public long ModId { get; set; }

	[JsonPropertyName("domain_name")]
	public string DomainName { get; set; }
}
