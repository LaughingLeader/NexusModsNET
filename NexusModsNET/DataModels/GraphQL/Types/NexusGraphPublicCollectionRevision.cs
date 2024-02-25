using Newtonsoft.Json;

using System;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphPublicCollectionRevision
	{
		[JsonProperty("collectionChangelog")]
		public NexusGraphPublicCollectionChangelog? CollectionChangelog { get; set; }

		[JsonProperty("createdAt")]
		public DateTimeOffset CreatedAt { get; set; }

		[JsonProperty("discardedAt")]
		public DateTimeOffset DiscardedAt { get; set; }

		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("overallRating")]
		public string OverallRating { get; set; }

		[JsonProperty("overallRatingCount")]
		public int OverallRatingCount { get; set; }

		[JsonProperty("revisionNumber")]
		public int RevisionNumber { get; set; }

		[JsonProperty("revisionStatus")]
		public string RevisionStatus { get; set; }

		[JsonProperty("updatedAt")]
		public DateTimeOffset UpdatedAt { get; set; }
	}
}