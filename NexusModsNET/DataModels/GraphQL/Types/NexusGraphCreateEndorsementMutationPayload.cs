namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphCreateEndorsementMutationPayload
{
	[JsonPropertyName("endorsement")]
	public NexusGraphEndorsement Endorsement { get; set; }

	[JsonPropertyName("success")]
	public bool Success { get; set; }
}