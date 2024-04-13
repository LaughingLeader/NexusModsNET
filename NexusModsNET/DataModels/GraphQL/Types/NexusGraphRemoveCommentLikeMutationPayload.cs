namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphRemoveCommentLikeMutationPayload
{
	[JsonPropertyName("comment")]
	public NexusGraphComment Comment { get; set; }
}