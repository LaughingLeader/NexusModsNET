using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphMutation
	{
		[JsonProperty("acceptModerationFix")]
		public NexusGraphAcceptModerationFixMutationPayload? AcceptModerationFix { get; set; }

		[JsonProperty("changeCollectionOwner")]
		public NexusGraphChangeCollectionOwnerPayload? ChangeCollectionOwner { get; set; }

		[JsonProperty("clearCommentModerationStatus")]
		public NexusGraphClearCommentModerationStatusMutationPayload? ClearCommentModerationStatus { get; set; }

		[JsonProperty("clearCommentThreadModerationStatus")]
		public NexusGraphClearThreadModerationStatusMutationPayload? ClearCommentThreadModerationStatus { get; set; }

		[JsonProperty("closeCollectionBugReport")]
		public NexusGraphCloseCollectionBugReportMutationPayload? CloseCollectionBugReport { get; set; }

		[JsonProperty("createChangelog")]
		public NexusGraphCreateChangelogMutationPayload? CreateChangelog { get; set; }

		[JsonProperty("createCollection")]
		public NexusGraphCreateCollectionMutationPayload? CreateCollection { get; set; }

		[JsonProperty("createComment")]
		public NexusGraphCreateCommentMutationPayload? CreateComment { get; set; }

		[JsonProperty("createMessage")]
		public NexusGraphCreateMessagePayload? CreateMessage { get; set; }

		[JsonProperty("createNoteAboutUser")]
		public NexusGraphCreateNoteAboutUserMutationPayload? CreateNoteAboutUser { get; set; }

		[JsonProperty("createOrUpdateRevision")]
		public NexusGraphCreateOrUpdateRevisionMutationPayload? CreateOrUpdateRevision { get; set; }

		[JsonProperty("createTag")]
		public NexusGraphCreateTagMutationPayload? CreateTag { get; set; }

		[JsonProperty("discardCollection")]
		public NexusGraphDiscardCollectionMutationPayload? DiscardCollection { get; set; }

		[JsonProperty("discardComment")]
		public NexusGraphDiscardCommentMutationPayload? DiscardComment { get; set; }

		[JsonProperty("discardRevision")]
		public NexusGraphDiscardRevisionMutationPayload? DiscardRevision { get; set; }

		[JsonProperty("discardTag")]
		public NexusGraphDiscardTagMutationPayload? DiscardTag { get; set; }

		[JsonProperty("editCollection")]
		public NexusGraphEditCollectionMutationPayload? EditCollection { get; set; }

		[JsonProperty("giveKudos")]
		public NexusGraphGiveKudosMutationPayload? GiveKudos { get; set; }

		[JsonProperty("hideComment")]
		public NexusGraphHideCommentMutationPayload? HideComment { get; set; }

		[JsonProperty("issueWarningToUser")]
		public NexusGraphIssueWarningToUserMutationPayload? IssueWarningToUser { get; set; }

		[JsonProperty("likeComment")]
		public NexusGraphLikeCommentMutationPayload? LikeComment { get; set; }

		[JsonProperty("listCollection")]
		public NexusGraphListCollectionMutationPayload? ListCollection { get; set; }

		[JsonProperty("lockComment")]
		public NexusGraphLockCommentMutationPayload? LockComment { get; set; }

		[JsonProperty("lockCommentThread")]
		public NexusGraphLockThreadMutationPayload? LockCommentThread { get; set; }

		[JsonProperty("pinComment")]
		public NexusGraphPinCommentMutationPayload? PinComment { get; set; }

		[JsonProperty("publishRevision")]
		public NexusGraphPublishRevisionMutationPayload? PublishRevision { get; set; }

		[JsonProperty("rejectModerationFix")]
		public NexusGraphRejectModerationFixMutationPayload? RejectModerationFix { get; set; }

		[JsonProperty("removeCommentLike")]
		public NexusGraphRemoveCommentLikeMutationPayload? RemoveCommentLike { get; set; }

		[JsonProperty("removeKudos")]
		public NexusGraphRemoveKudosMutationPayload? RemoveKudos { get; set; }

		[JsonProperty("reorderItem")]
		public NexusGraphReorderItemPayload? ReorderItem { get; set; }

		[JsonProperty("reorderPinnedComments")]
		public NexusGraphReorderPinnedCommentsMutationPayload? ReorderPinnedComments { get; set; }

		[JsonProperty("reportCollection")]
		public NexusGraphReportCollectionMutationPayload? ReportCollection { get; set; }

		[JsonProperty("reportCollectionBugReport")]
		public NexusGraphReportCollectionBugReportMutationPayload? ReportCollectionBugReport { get; set; }

		[JsonProperty("reportComment")]
		public NexusGraphReportCommentMutationPayload? ReportComment { get; set; }

		[JsonProperty("restoreComment")]
		public NexusGraphRestoreCommentMutationPayload? RestoreComment { get; set; }

		[JsonProperty("retractRevision")]
		public NexusGraphRetractRevisionMutationPayload? RetractRevision { get; set; }

		[JsonProperty("submitModerationFix")]
		public NexusGraphSubmitModerationFixMutationPayload? SubmitModerationFix { get; set; }

		[JsonProperty("trackUser")]
		public NexusGraphTrackUserMutationPayload? TrackUser { get; set; }

		[JsonProperty("unlistCollection")]
		public NexusGraphUnlistCollectionMutationPayload? UnlistCollection { get; set; }

		[JsonProperty("unpinComment")]
		public NexusGraphUnpinCommentMutationPayload? UnpinComment { get; set; }

		[JsonProperty("untrackUser")]
		public NexusGraphUntrackUserMutationPayload? UntrackUser { get; set; }

		[JsonProperty("updateAboutMe")]
		public NexusGraphUpdateAboutMeMutationPayload? UpdateAboutMe { get; set; }

		[JsonProperty("updateChangelog")]
		public NexusGraphUpdateChangelogMutationPayload? UpdateChangelog { get; set; }

		[JsonProperty("updateComment")]
		public NexusGraphUpdateCommentMutationPayload? UpdateComment { get; set; }

		[JsonProperty("updateCountry")]
		public NexusGraphUpdateCountryMutationPayload? UpdateCountry { get; set; }

		[JsonProperty("updateRevision")]
		public NexusGraphUpdateRevisionMutationPayload? UpdateRevision { get; set; }

		[JsonProperty("updateTag")]
		public NexusGraphUpdateTagMutationPayload? UpdateTag { get; set; }

		[JsonProperty("uploadAttachment")]
		public NexusGraphUploadAttachmentMutationPayload? UploadAttachment { get; set; }

		[JsonProperty("writeFullPageNotificationToUser")]
		public NexusGraphWriteFullPageNotificationToUserMutationPayload? WriteFullPageNotificationToUser { get; set; }
	}
}