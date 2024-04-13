namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphCreateTagMutationPayload
{
	[JsonPropertyName("success")]
	public bool Success { get; set; }

	[JsonPropertyName("tag")]
	public NexusGraphTag? Tag { get; set; }
}