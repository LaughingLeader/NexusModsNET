using Newtonsoft.Json;

using System;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphCollectionBugReport : INexusGraphAttachable
	{
		[JsonProperty("attachments")]
		public NexusGraphAttachment[] Attachments { get; set; }

		[JsonProperty("closedAt")]
		public DateTimeOffset ClosedAt { get; set; }

		[JsonProperty("closureReason")]
		public NexusGraphBugReportClosureReason? ClosureReason { get; set; }

		[JsonProperty("collection")]
		public NexusGraphCollection Collection { get; set; }

		[JsonProperty("collectionRevisionNumber")]
		public int CollectionRevisionNumber { get; set; }

		[JsonProperty("commentThread")]
		public NexusGraphCommentThread CommentThread { get; set; }

		[JsonProperty("createdAt")]
		public DateTimeOffset CreatedAt { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("hiddenBy")]
		public NexusGraphUser? HiddenBy { get; set; }

		[JsonProperty("hiddenInternalReason")]
		public string HiddenInternalReason { get; set; }

		[JsonProperty("hiddenReason")]
		public string HiddenReason { get; set; }

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("moderationStatus")]
		public NexusGraphBugReportModerationStatus ModerationStatus { get; set; }

		[JsonProperty("openedAt")]
		public DateTimeOffset OpenedAt { get; set; }

		[JsonProperty("permissions")]
		public NexusGraphPermission[] Permissions { get; set; }

		[JsonProperty("reporter")]
		public NexusGraphUser Reporter { get; set; }

		[JsonProperty("status")]
		public NexusGraphBugReportStatus Status { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }

		[JsonProperty("updatedAt")]
		public DateTimeOffset UpdatedAt { get; set; }
	}
}