namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphRestoreCommentMutationPayload
{
	[JsonPropertyName("comment")]
	public NexusGraphComment Comment { get; set; }
}