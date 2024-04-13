namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphLockCommentMutationPayload
{
	[JsonPropertyName("comment")]
	public NexusGraphComment Comment { get; set; }
}