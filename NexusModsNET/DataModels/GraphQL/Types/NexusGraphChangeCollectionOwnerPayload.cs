namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphChangeCollectionOwnerPayload
{
	[JsonPropertyName("collection")]
	public NexusGraphCollection Collection { get; set; }

	[JsonPropertyName("success")]
	public bool Success { get; set; }
}