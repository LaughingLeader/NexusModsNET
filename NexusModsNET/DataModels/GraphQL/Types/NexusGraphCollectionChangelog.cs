using Newtonsoft.Json;

using System;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphCollectionChangelog
	{
		[JsonProperty("collectionRevisionId")]
		public int CollectionRevisionId { get; set; }

		[JsonProperty("createdAt")]
		public DateTimeOffset CreatedAt { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("revisionNumber")]
		public int RevisionNumber { get; set; }

		[JsonProperty("updatedAt")]
		public DateTimeOffset UpdatedAt { get; set; }
	}
}