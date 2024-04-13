namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphLikeCommentMutationPayload
{
	[JsonPropertyName("comment")]
	public NexusGraphComment Comment { get; set; }
}