namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphAddHeaderImageToCollectionMutationPayload
{
	[JsonPropertyName("image")]
	public NexusGraphCollectionImage Image { get; set; }
}