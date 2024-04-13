namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphHideCommentMutationPayload
{
	[JsonPropertyName("comment")]
	public NexusGraphComment Comment { get; set; }
}