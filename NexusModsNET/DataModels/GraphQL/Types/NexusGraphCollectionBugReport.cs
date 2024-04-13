namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphCollectionBugReport : INexusGraphAttachable
{
	[JsonPropertyName("attachments")]
	public NexusGraphAttachment[] Attachments { get; set; }

	[JsonPropertyName("closedAt")]
	public DateTimeOffset ClosedAt { get; set; }

	[JsonPropertyName("closureReason")]
	public NexusGraphBugReportClosureReason? ClosureReason { get; set; }

	[JsonPropertyName("collection")]
	public NexusGraphCollection Collection { get; set; }

	[JsonPropertyName("collectionRevisionNumber")]
	public int CollectionRevisionNumber { get; set; }

	[JsonPropertyName("commentThread")]
	public NexusGraphCommentThread CommentThread { get; set; }

	[JsonPropertyName("createdAt")]
	public DateTimeOffset CreatedAt { get; set; }

	[JsonPropertyName("description")]
	public string Description { get; set; }

	[JsonPropertyName("hiddenBy")]
	public NexusGraphUser? HiddenBy { get; set; }

	[JsonPropertyName("hiddenInternalReason")]
	public string HiddenInternalReason { get; set; }

	[JsonPropertyName("hiddenReason")]
	public string HiddenReason { get; set; }

	[JsonPropertyName("id")]
	public string Id { get; set; }

	[JsonPropertyName("moderationStatus")]
	public NexusGraphBugReportModerationStatus ModerationStatus { get; set; }

	[JsonPropertyName("openedAt")]
	public DateTimeOffset OpenedAt { get; set; }

	[JsonPropertyName("permissions")]
	public NexusGraphPermission[] Permissions { get; set; }

	[JsonPropertyName("reporter")]
	public NexusGraphUser Reporter { get; set; }

	[JsonPropertyName("status")]
	public NexusGraphBugReportStatus Status { get; set; }

	[JsonPropertyName("title")]
	public string Title { get; set; }

	[JsonPropertyName("updatedAt")]
	public DateTimeOffset UpdatedAt { get; set; }
}