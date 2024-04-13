namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphAcceptModerationFixMutationPayload
{
	[JsonPropertyName("moderationFix")]
	public NexusGraphModerationFix ModerationFix { get; set; }

	[JsonPropertyName("success")]
	public bool Success { get; set; }
}