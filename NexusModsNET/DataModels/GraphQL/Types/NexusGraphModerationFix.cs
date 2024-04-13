namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphModerationFix
{
	[JsonPropertyName("author")]
	public NexusGraphUser Author { get; set; }

	[JsonPropertyName("authorId")]
	public string AuthorId { get; set; }

	[JsonPropertyName("createdAt")]
	public DateTimeOffset CreatedAt { get; set; }

	[JsonPropertyName("description")]
	public string Description { get; set; }

	[JsonPropertyName("id")]
	public string Id { get; set; }

	[JsonPropertyName("moderation")]
	public NexusGraphModeration Moderation { get; set; }

	[JsonPropertyName("status")]
	public NexusGraphModerationFixStatus Status { get; set; }

	[JsonPropertyName("updatedAt")]
	public DateTimeOffset UpdatedAt { get; set; }
}