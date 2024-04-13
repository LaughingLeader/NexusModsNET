namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphCommentRevision : INexusGraphNode
{
	[JsonPropertyName("body")]
	public string Body { get; set; }

	[JsonPropertyName("createdAt")]
	public DateTimeOffset CreatedAt { get; set; }

	[JsonPropertyName("id")]
	public string Id { get; set; }

	[JsonPropertyName("updatedAt")]
	public DateTimeOffset UpdatedAt { get; set; }
}