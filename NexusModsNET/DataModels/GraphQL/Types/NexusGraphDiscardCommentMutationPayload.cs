namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphDiscardCommentMutationPayload
{
	[JsonPropertyName("comment")]
	public NexusGraphComment Comment { get; set; }
}