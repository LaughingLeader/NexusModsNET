namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphTag
{
	[JsonPropertyName("adult")]
	public bool Adult { get; set; }

	[JsonPropertyName("category")]
	public NexusGraphTagCategory? Category { get; set; }

	[JsonPropertyName("createdAt")]
	public DateTimeOffset CreatedAt { get; set; }

	[JsonPropertyName("discardedAt")]
	public DateTimeOffset DiscardedAt { get; set; }

	[JsonPropertyName("games")]
	public NexusGraphGame[] Games { get; set; }

	[JsonPropertyName("global")]
	public bool Global { get; set; }

	[JsonPropertyName("id")]
	public string Id { get; set; }

	[JsonPropertyName("name")]
	public string Name { get; set; }

	[JsonPropertyName("taggablesCount")]
	public int TaggablesCount { get; set; }

	[JsonPropertyName("updatedAt")]
	public DateTimeOffset UpdatedAt { get; set; }
}