namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphCreateCommentMutationPayload
{
	[JsonPropertyName("comment")]
	public NexusGraphComment Comment { get; set; }
}