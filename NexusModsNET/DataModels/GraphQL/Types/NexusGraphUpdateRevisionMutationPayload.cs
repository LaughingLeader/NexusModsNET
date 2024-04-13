namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphUpdateRevisionMutationPayload
{
	[JsonPropertyName("revisionId")]
	public int RevisionId { get; set; }

	[JsonPropertyName("success")]
	public bool Success { get; set; }
}