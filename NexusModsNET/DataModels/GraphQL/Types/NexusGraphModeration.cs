using Newtonsoft.Json;

using System;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphModeration
	{
		[JsonProperty("createdAt")]
		public DateTimeOffset CreatedAt { get; set; }

		[JsonProperty("editable")]
		public bool Editable { get; set; }

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("moderatableId")]
		public string ModeratableId { get; set; }

		[JsonProperty("moderatableType")]
		public NexusGraphModeratable ModeratableType { get; set; }

		[JsonProperty("moderationFixes")]
		public NexusGraphModerationFix[] ModerationFixes { get; set; }

		[JsonProperty("moderationReason")]
		public NexusGraphModerationReason ModerationReason { get; set; }

		[JsonProperty("staffId")]
		public string StaffId { get; set; }

		[JsonProperty("staffNote")]
		public string StaffNote { get; set; }

		[JsonProperty("unlockedAt")]
		public DateTimeOffset UnlockedAt { get; set; }

		[JsonProperty("unlockedBy")]
		public string UnlockedBy { get; set; }

		[JsonProperty("unlockedNote")]
		public string UnlockedNote { get; set; }

		[JsonProperty("updatedAt")]
		public DateTimeOffset UpdatedAt { get; set; }

		[JsonProperty("user")]
		public NexusGraphUser User { get; set; }

		[JsonProperty("userNote")]
		public string UserNote { get; set; }
	}
}