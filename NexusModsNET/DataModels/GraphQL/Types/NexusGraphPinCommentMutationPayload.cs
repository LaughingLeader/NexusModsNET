namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphPinCommentMutationPayload
{
	[JsonPropertyName("comment")]
	public NexusGraphComment Comment { get; set; }
}