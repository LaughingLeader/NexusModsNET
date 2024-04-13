namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphModerateMutationPayload
{
	[JsonPropertyName("moderation")]
	public NexusGraphModeration Moderation { get; set; }

	[JsonPropertyName("success")]
	public bool Success { get; set; }
}