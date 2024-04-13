namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphEditCollectionMutationPayload
{
	[JsonPropertyName("collection")]
	public NexusGraphCollection Collection { get; set; }

	[JsonPropertyName("success")]
	public bool Success { get; set; }
}