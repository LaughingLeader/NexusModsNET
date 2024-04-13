namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphGameVersion
{
	[JsonPropertyName("id")]
	public string Id { get; set; }

	[JsonPropertyName("reference")]
	public string Reference { get; set; }
}