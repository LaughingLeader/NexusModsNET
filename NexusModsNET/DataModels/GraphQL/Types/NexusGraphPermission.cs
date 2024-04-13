namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphPermission
{
	[JsonPropertyName("global")]
	public bool Global { get; set; }

	[JsonPropertyName("key")]
	public string Key { get; set; }
}