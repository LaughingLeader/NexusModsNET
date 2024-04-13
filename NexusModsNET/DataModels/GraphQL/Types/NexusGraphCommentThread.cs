namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphCommentThread
{
	[JsonPropertyName("comments")]
	public NexusGraphCommentConnection Comments { get; set; }

	[JsonPropertyName("id")]
	public string Id { get; set; }

	[JsonPropertyName("lockedAt")]
	public DateTimeOffset LockedAt { get; set; }

	[JsonPropertyName("lockedBy")]
	public NexusGraphUser? LockedBy { get; set; }

	[JsonPropertyName("moderatedByAdmin")]
	public bool ModeratedByAdmin { get; set; }

	[JsonPropertyName("moderationStatus")]
	public NexusGraphCommentThreadModerationStatus ModerationStatus { get; set; }

	[JsonPropertyName("owner")]
	public NexusGraphUser Owner { get; set; }
}