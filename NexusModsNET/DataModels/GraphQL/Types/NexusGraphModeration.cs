namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphModeration
{
	[JsonPropertyName("createdAt")]
	public DateTimeOffset CreatedAt { get; set; }

	[JsonPropertyName("editable")]
	public bool Editable { get; set; }

	[JsonPropertyName("id")]
	public string Id { get; set; }

	[JsonPropertyName("moderatableId")]
	public string ModeratableId { get; set; }

	[JsonPropertyName("moderatableType")]
	public NexusGraphModeratable ModeratableType { get; set; }

	[JsonPropertyName("moderationFixes")]
	public NexusGraphModerationFix[] ModerationFixes { get; set; }

	[JsonPropertyName("moderationReason")]
	public NexusGraphModerationReason ModerationReason { get; set; }

	[JsonPropertyName("staffId")]
	public string StaffId { get; set; }

	[JsonPropertyName("staffNote")]
	public string StaffNote { get; set; }

	[JsonPropertyName("unlockedAt")]
	public DateTimeOffset UnlockedAt { get; set; }

	[JsonPropertyName("unlockedBy")]
	public string UnlockedBy { get; set; }

	[JsonPropertyName("unlockedNote")]
	public string UnlockedNote { get; set; }

	[JsonPropertyName("updatedAt")]
	public DateTimeOffset UpdatedAt { get; set; }

	[JsonPropertyName("user")]
	public NexusGraphUser User { get; set; }

	[JsonPropertyName("userNote")]
	public string UserNote { get; set; }
}