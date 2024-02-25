using Newtonsoft.Json;

using System;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphCommentThread
	{
		[JsonProperty("comments")]
		public NexusGraphCommentConnection Comments { get; set; }

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("lockedAt")]
		public DateTimeOffset LockedAt { get; set; }

		[JsonProperty("lockedBy")]
		public NexusGraphUser? LockedBy { get; set; }

		[JsonProperty("moderatedByAdmin")]
		public bool ModeratedByAdmin { get; set; }

		[JsonProperty("moderationStatus")]
		public NexusGraphCommentThreadModerationStatus ModerationStatus { get; set; }

		[JsonProperty("owner")]
		public NexusGraphUser Owner { get; set; }
	}
}