using Newtonsoft.Json;

using System;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphTag
	{
		[JsonProperty("adult")]
		public bool Adult { get; set; }

		[JsonProperty("category")]
		public NexusGraphTagCategory? Category { get; set; }

		[JsonProperty("createdAt")]
		public DateTimeOffset CreatedAt { get; set; }

		[JsonProperty("discardedAt")]
		public DateTimeOffset DiscardedAt { get; set; }

		[JsonProperty("games")]
		public NexusGraphGame[] Games { get; set; }

		[JsonProperty("global")]
		public bool Global { get; set; }

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("taggablesCount")]
		public int TaggablesCount { get; set; }

		[JsonProperty("updatedAt")]
		public DateTimeOffset UpdatedAt { get; set; }
	}
}