namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphCollectionSchema
{
	[JsonPropertyName("createdAt")]
	public DateTimeOffset CreatedAt { get; set; }

	[JsonPropertyName("id")]
	public int Id { get; set; }

	[JsonPropertyName("updatedAt")]
	public DateTimeOffset UpdatedAt { get; set; }

	[JsonPropertyName("version")]
	public string Version { get; set; }
}