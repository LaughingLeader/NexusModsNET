namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphReorderPinnedCommentsMutationPayload
{
	[JsonPropertyName("comments")]
	public NexusGraphComment[] Comments { get; set; }
}