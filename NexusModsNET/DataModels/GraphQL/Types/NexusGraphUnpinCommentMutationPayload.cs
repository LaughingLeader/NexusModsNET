namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphUnpinCommentMutationPayload
{
	[JsonPropertyName("comment")]
	public NexusGraphComment Comment { get; set; }
}