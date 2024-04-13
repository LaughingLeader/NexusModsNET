namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphClearCommentModerationStatusMutationPayload
{
	[JsonPropertyName("comment")]
	public NexusGraphComment Comment { get; set; }
}