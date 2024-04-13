namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphRejectModerationFixMutationPayload
{
	[JsonPropertyName("moderationFix")]
	public NexusGraphModerationFix ModerationFix { get; set; }

	[JsonPropertyName("success")]
	public bool Success { get; set; }
}