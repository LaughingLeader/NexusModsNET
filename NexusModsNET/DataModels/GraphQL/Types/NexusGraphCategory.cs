namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphCategory
{
	[JsonPropertyName("approved")]
	public bool Approved { get; set; }

	[JsonPropertyName("approvedBy")]
	public int ApprovedBy { get; set; }

	[JsonPropertyName("categoryGames")]
	public NexusGraphGame[] CategoryGames { get; set; }

	[JsonPropertyName("createdAt")]
	public DateTimeOffset CreatedAt { get; set; }

	[JsonPropertyName("description")]
	public string Description { get; set; }

	[JsonPropertyName("discardedAt")]
	public DateTimeOffset DiscardedAt { get; set; }

	[JsonPropertyName("id")]
	public int Id { get; set; }

	[JsonPropertyName("name")]
	public string Name { get; set; }

	[JsonPropertyName("parentId")]
	public int ParentId { get; set; }

	[JsonPropertyName("suggestedBy")]
	public int SuggestedBy { get; set; }

	[JsonPropertyName("updatedAt")]
	public DateTimeOffset UpdatedAt { get; set; }
}