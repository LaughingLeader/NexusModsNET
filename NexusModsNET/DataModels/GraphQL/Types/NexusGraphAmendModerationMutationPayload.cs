namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphAmendModerationMutationPayload
{
	[JsonPropertyName("moderation")]
	public NexusGraphModeration Moderation { get; set; }

	[JsonPropertyName("success")]
	public bool Success { get; set; }
}