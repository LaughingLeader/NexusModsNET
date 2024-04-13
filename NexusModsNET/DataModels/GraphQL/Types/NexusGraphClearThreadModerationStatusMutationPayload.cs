namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphClearThreadModerationStatusMutationPayload
{
	[JsonPropertyName("commentThread")]
	public NexusGraphCommentThread CommentThread { get; set; }
}