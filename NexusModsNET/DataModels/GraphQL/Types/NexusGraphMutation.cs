namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphMutation
{
	[JsonPropertyName("acceptModerationFix")]
	public NexusGraphAcceptModerationFixMutationPayload? AcceptModerationFix { get; set; }

	[JsonPropertyName("changeCollectionOwner")]
	public NexusGraphChangeCollectionOwnerPayload? ChangeCollectionOwner { get; set; }

	[JsonPropertyName("clearCommentModerationStatus")]
	public NexusGraphClearCommentModerationStatusMutationPayload? ClearCommentModerationStatus { get; set; }

	[JsonPropertyName("clearCommentThreadModerationStatus")]
	public NexusGraphClearThreadModerationStatusMutationPayload? ClearCommentThreadModerationStatus { get; set; }

	[JsonPropertyName("closeCollectionBugReport")]
	public NexusGraphCloseCollectionBugReportMutationPayload? CloseCollectionBugReport { get; set; }

	[JsonPropertyName("createChangelog")]
	public NexusGraphCreateChangelogMutationPayload? CreateChangelog { get; set; }

	[JsonPropertyName("createCollection")]
	public NexusGraphCreateCollectionMutationPayload? CreateCollection { get; set; }

	[JsonPropertyName("createComment")]
	public NexusGraphCreateCommentMutationPayload? CreateComment { get; set; }

	[JsonPropertyName("createMessage")]
	public NexusGraphCreateMessagePayload? CreateMessage { get; set; }

	[JsonPropertyName("createNoteAboutUser")]
	public NexusGraphCreateNoteAboutUserMutationPayload? CreateNoteAboutUser { get; set; }

	[JsonPropertyName("createOrUpdateRevision")]
	public NexusGraphCreateOrUpdateRevisionMutationPayload? CreateOrUpdateRevision { get; set; }

	[JsonPropertyName("createTag")]
	public NexusGraphCreateTagMutationPayload? CreateTag { get; set; }

	[JsonPropertyName("discardCollection")]
	public NexusGraphDiscardCollectionMutationPayload? DiscardCollection { get; set; }

	[JsonPropertyName("discardComment")]
	public NexusGraphDiscardCommentMutationPayload? DiscardComment { get; set; }

	[JsonPropertyName("discardRevision")]
	public NexusGraphDiscardRevisionMutationPayload? DiscardRevision { get; set; }

	[JsonPropertyName("discardTag")]
	public NexusGraphDiscardTagMutationPayload? DiscardTag { get; set; }

	[JsonPropertyName("editCollection")]
	public NexusGraphEditCollectionMutationPayload? EditCollection { get; set; }

	[JsonPropertyName("giveKudos")]
	public NexusGraphGiveKudosMutationPayload? GiveKudos { get; set; }

	[JsonPropertyName("hideComment")]
	public NexusGraphHideCommentMutationPayload? HideComment { get; set; }

	[JsonPropertyName("issueWarningToUser")]
	public NexusGraphIssueWarningToUserMutationPayload? IssueWarningToUser { get; set; }

	[JsonPropertyName("likeComment")]
	public NexusGraphLikeCommentMutationPayload? LikeComment { get; set; }

	[JsonPropertyName("listCollection")]
	public NexusGraphListCollectionMutationPayload? ListCollection { get; set; }

	[JsonPropertyName("lockComment")]
	public NexusGraphLockCommentMutationPayload? LockComment { get; set; }

	[JsonPropertyName("lockCommentThread")]
	public NexusGraphLockThreadMutationPayload? LockCommentThread { get; set; }

	[JsonPropertyName("pinComment")]
	public NexusGraphPinCommentMutationPayload? PinComment { get; set; }

	[JsonPropertyName("publishRevision")]
	public NexusGraphPublishRevisionMutationPayload? PublishRevision { get; set; }

	[JsonPropertyName("rejectModerationFix")]
	public NexusGraphRejectModerationFixMutationPayload? RejectModerationFix { get; set; }

	[JsonPropertyName("removeCommentLike")]
	public NexusGraphRemoveCommentLikeMutationPayload? RemoveCommentLike { get; set; }

	[JsonPropertyName("removeKudos")]
	public NexusGraphRemoveKudosMutationPayload? RemoveKudos { get; set; }

	[JsonPropertyName("reorderItem")]
	public NexusGraphReorderItemPayload? ReorderItem { get; set; }

	[JsonPropertyName("reorderPinnedComments")]
	public NexusGraphReorderPinnedCommentsMutationPayload? ReorderPinnedComments { get; set; }

	[JsonPropertyName("reportCollection")]
	public NexusGraphReportCollectionMutationPayload? ReportCollection { get; set; }

	[JsonPropertyName("reportCollectionBugReport")]
	public NexusGraphReportCollectionBugReportMutationPayload? ReportCollectionBugReport { get; set; }

	[JsonPropertyName("reportComment")]
	public NexusGraphReportCommentMutationPayload? ReportComment { get; set; }

	[JsonPropertyName("restoreComment")]
	public NexusGraphRestoreCommentMutationPayload? RestoreComment { get; set; }

	[JsonPropertyName("retractRevision")]
	public NexusGraphRetractRevisionMutationPayload? RetractRevision { get; set; }

	[JsonPropertyName("submitModerationFix")]
	public NexusGraphSubmitModerationFixMutationPayload? SubmitModerationFix { get; set; }

	[JsonPropertyName("trackUser")]
	public NexusGraphTrackUserMutationPayload? TrackUser { get; set; }

	[JsonPropertyName("unlistCollection")]
	public NexusGraphUnlistCollectionMutationPayload? UnlistCollection { get; set; }

	[JsonPropertyName("unpinComment")]
	public NexusGraphUnpinCommentMutationPayload? UnpinComment { get; set; }

	[JsonPropertyName("untrackUser")]
	public NexusGraphUntrackUserMutationPayload? UntrackUser { get; set; }

	[JsonPropertyName("updateAboutMe")]
	public NexusGraphUpdateAboutMeMutationPayload? UpdateAboutMe { get; set; }

	[JsonPropertyName("updateChangelog")]
	public NexusGraphUpdateChangelogMutationPayload? UpdateChangelog { get; set; }

	[JsonPropertyName("updateComment")]
	public NexusGraphUpdateCommentMutationPayload? UpdateComment { get; set; }

	[JsonPropertyName("updateCountry")]
	public NexusGraphUpdateCountryMutationPayload? UpdateCountry { get; set; }

	[JsonPropertyName("updateRevision")]
	public NexusGraphUpdateRevisionMutationPayload? UpdateRevision { get; set; }

	[JsonPropertyName("updateTag")]
	public NexusGraphUpdateTagMutationPayload? UpdateTag { get; set; }

	[JsonPropertyName("uploadAttachment")]
	public NexusGraphUploadAttachmentMutationPayload? UploadAttachment { get; set; }

	[JsonPropertyName("writeFullPageNotificationToUser")]
	public NexusGraphWriteFullPageNotificationToUserMutationPayload? WriteFullPageNotificationToUser { get; set; }
}