using Newtonsoft.Json;

using System;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphRetractionReason
	{
		[JsonProperty("collectionRevisionId")]
		public int CollectionRevisionId { get; set; }

		[JsonProperty("createdAt")]
		public DateTimeOffset CreatedAt { get; set; }

		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("reason")]
		public string Reason { get; set; }

		[JsonProperty("updatedAt")]
		public DateTimeOffset UpdatedAt { get; set; }
	}
}