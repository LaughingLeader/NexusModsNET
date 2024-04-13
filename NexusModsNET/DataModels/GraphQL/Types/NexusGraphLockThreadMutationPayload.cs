namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphLockThreadMutationPayload
{
	[JsonPropertyName("commentThread")]
	public NexusGraphCommentThread CommentThread { get; set; }
}