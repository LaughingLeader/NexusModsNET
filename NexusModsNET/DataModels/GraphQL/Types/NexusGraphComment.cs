namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphComment : INexusGraphAttachable
{
	[JsonPropertyName("attachments")]
	public NexusGraphAttachment[] Attachments { get; set; }

	[JsonPropertyName("body")]
	public string Body { get; set; }

	[JsonPropertyName("createdAt")]
	public DateTimeOffset CreatedAt { get; set; }

	[JsonPropertyName("creator")]
	public NexusGraphUser Creator { get; set; }

	[JsonPropertyName("cursor")]
	public string Cursor { get; set; }

	[JsonPropertyName("discardedAt")]
	public DateTimeOffset DiscardedAt { get; set; }

	[JsonPropertyName("discardedBy")]
	public NexusGraphUser? DiscardedBy { get; set; }

	[JsonPropertyName("hiddenAt")]
	public DateTimeOffset HiddenAt { get; set; }

	[JsonPropertyName("hiddenBy")]
	public NexusGraphUser? HiddenBy { get; set; }

	[JsonPropertyName("hiddenInternalReason")]
	public string HiddenInternalReason { get; set; }

	[JsonPropertyName("hiddenReason")]
	public string HiddenReason { get; set; }

	[JsonPropertyName("id")]
	public string Id { get; set; }

	[JsonPropertyName("isDiscarded")]
	public bool IsDiscarded { get; set; }

	[JsonPropertyName("isPinned")]
	public bool IsPinned { get; set; }

	[JsonPropertyName("likesCount")]
	public int LikesCount { get; set; }

	[JsonPropertyName("lockedAt")]
	public DateTimeOffset LockedAt { get; set; }

	[JsonPropertyName("lockedBy")]
	public NexusGraphUser? LockedBy { get; set; }

	[JsonPropertyName("moderatedByAdmin")]
	public bool ModeratedByAdmin { get; set; }

	[JsonPropertyName("moderationStatus")]
	public NexusGraphCommentModerationStatus ModerationStatus { get; set; }

	[JsonPropertyName("parent")]
	public NexusGraphComment? Parent { get; set; }

	[JsonPropertyName("pinPriority")]
	public int PinPriority { get; set; }

	[JsonPropertyName("pinnedBy")]
	public NexusGraphUser? PinnedBy { get; set; }

	[JsonPropertyName("pinnedByAdmin")]
	public bool PinnedByAdmin { get; set; }

	[JsonPropertyName("replies")]
	public NexusGraphCommentConnection Replies { get; set; }

	[JsonPropertyName("revisions")]
	public NexusGraphCommentRevision[] Revisions { get; set; }

	[JsonPropertyName("updatedAt")]
	public DateTimeOffset UpdatedAt { get; set; }

	[JsonPropertyName("viewerHasLiked")]
	public bool ViewerHasLiked { get; set; }
}