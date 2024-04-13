namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphAddImageToCollectionMutationPayload
{
	[JsonPropertyName("image")]
	public NexusGraphCollectionImage Image { get; set; }
}