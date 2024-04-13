namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphAddVideoToCollectionMutationPayload
{
	[JsonPropertyName("video")]
	public NexusGraphCollectionVideo Video { get; set; }
}