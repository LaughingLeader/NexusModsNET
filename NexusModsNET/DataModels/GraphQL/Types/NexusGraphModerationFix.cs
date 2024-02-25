using Newtonsoft.Json;

using System;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphModerationFix
	{
		[JsonProperty("author")]
		public NexusGraphUser Author { get; set; }

		[JsonProperty("authorId")]
		public string AuthorId { get; set; }

		[JsonProperty("createdAt")]
		public DateTimeOffset CreatedAt { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("moderation")]
		public NexusGraphModeration Moderation { get; set; }

		[JsonProperty("status")]
		public NexusGraphModerationFixStatus Status { get; set; }

		[JsonProperty("updatedAt")]
		public DateTimeOffset UpdatedAt { get; set; }
	}
}