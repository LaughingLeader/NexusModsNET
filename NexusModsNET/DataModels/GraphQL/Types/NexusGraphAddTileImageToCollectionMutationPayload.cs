namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphAddTileImageToCollectionMutationPayload
{
	[JsonPropertyName("image")]
	public NexusGraphCollectionImage Image { get; set; }
}