using Newtonsoft.Json;

using System;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphTagCategory
	{
		[JsonProperty("createdAt")]
		public DateTimeOffset CreatedAt { get; set; }

		[JsonProperty("discardedAt")]
		public DateTimeOffset DiscardedAt { get; set; }

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("tags")]
		public NexusGraphTag[] Tags { get; set; }

		[JsonProperty("updatedAt")]
		public DateTimeOffset UpdatedAt { get; set; }
	}
}