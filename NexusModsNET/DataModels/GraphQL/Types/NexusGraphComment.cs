using Newtonsoft.Json;

using System;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphComment : INexusGraphAttachable
	{
		[JsonProperty("attachments")]
		public NexusGraphAttachment[] Attachments { get; set; }

		[JsonProperty("body")]
		public string Body { get; set; }

		[JsonProperty("createdAt")]
		public DateTimeOffset CreatedAt { get; set; }

		[JsonProperty("creator")]
		public NexusGraphUser Creator { get; set; }

		[JsonProperty("cursor")]
		public string Cursor { get; set; }

		[JsonProperty("discardedAt")]
		public DateTimeOffset DiscardedAt { get; set; }

		[JsonProperty("discardedBy")]
		public NexusGraphUser? DiscardedBy { get; set; }

		[JsonProperty("hiddenAt")]
		public DateTimeOffset HiddenAt { get; set; }

		[JsonProperty("hiddenBy")]
		public NexusGraphUser? HiddenBy { get; set; }

		[JsonProperty("hiddenInternalReason")]
		public string HiddenInternalReason { get; set; }

		[JsonProperty("hiddenReason")]
		public string HiddenReason { get; set; }

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("isDiscarded")]
		public bool IsDiscarded { get; set; }

		[JsonProperty("isPinned")]
		public bool IsPinned { get; set; }

		[JsonProperty("likesCount")]
		public int LikesCount { get; set; }

		[JsonProperty("lockedAt")]
		public DateTimeOffset LockedAt { get; set; }

		[JsonProperty("lockedBy")]
		public NexusGraphUser? LockedBy { get; set; }

		[JsonProperty("moderatedByAdmin")]
		public bool ModeratedByAdmin { get; set; }

		[JsonProperty("moderationStatus")]
		public NexusGraphCommentModerationStatus ModerationStatus { get; set; }

		[JsonProperty("parent")]
		public NexusGraphComment? Parent { get; set; }

		[JsonProperty("pinPriority")]
		public int PinPriority { get; set; }

		[JsonProperty("pinnedBy")]
		public NexusGraphUser? PinnedBy { get; set; }

		[JsonProperty("pinnedByAdmin")]
		public bool PinnedByAdmin { get; set; }

		[JsonProperty("replies")]
		public NexusGraphCommentConnection Replies { get; set; }

		[JsonProperty("revisions")]
		public NexusGraphCommentRevision[] Revisions { get; set; }

		[JsonProperty("updatedAt")]
		public DateTimeOffset UpdatedAt { get; set; }

		[JsonProperty("viewerHasLiked")]
		public bool ViewerHasLiked { get; set; }
	}
}