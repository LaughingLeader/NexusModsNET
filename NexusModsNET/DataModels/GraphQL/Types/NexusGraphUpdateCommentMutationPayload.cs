namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphUpdateCommentMutationPayload
{
	[JsonPropertyName("comment")]
	public NexusGraphComment Comment { get; set; }
}