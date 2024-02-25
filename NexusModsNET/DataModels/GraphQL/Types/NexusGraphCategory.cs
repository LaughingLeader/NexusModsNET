using Newtonsoft.Json;

using System;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphCategory
	{
		[JsonProperty("approved")]
		public bool Approved { get; set; }

		[JsonProperty("approvedBy")]
		public int ApprovedBy { get; set; }

		[JsonProperty("categoryGames")]
		public NexusGraphGame[] CategoryGames { get; set; }

		[JsonProperty("createdAt")]
		public DateTimeOffset CreatedAt { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("discardedAt")]
		public DateTimeOffset DiscardedAt { get; set; }

		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("parentId")]
		public int ParentId { get; set; }

		[JsonProperty("suggestedBy")]
		public int SuggestedBy { get; set; }

		[JsonProperty("updatedAt")]
		public DateTimeOffset UpdatedAt { get; set; }
	}
}