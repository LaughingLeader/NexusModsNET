namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphModifyImageForCollectionMutationPayload
{
	[JsonPropertyName("image")]
	public NexusGraphCollectionImage Image { get; set; }

	[JsonPropertyName("updated")]
	public bool Updated { get; set; }
}