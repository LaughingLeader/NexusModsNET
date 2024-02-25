using Newtonsoft.Json;

using System;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphCollectionRevision
	{
		[JsonProperty("adultContent")]
		public bool AdultContent { get; set; }

		[JsonProperty("assetsSizeBytes")]
		public long AssetsSizeBytes { get; set; }

		[JsonProperty("collection")]
		public NexusGraphCollection Collection { get; set; }

		[JsonProperty("collectionChangelog")]
		public NexusGraphCollectionChangelog? CollectionChangelog { get; set; }

		[JsonProperty("collectionId")]
		public int CollectionId { get; set; }

		[JsonProperty("collectionSchema")]
		public NexusGraphCollectionSchema CollectionSchema { get; set; }

		[JsonProperty("collectionSchemaId")]
		public int CollectionSchemaId { get; set; }

		[JsonProperty("contentPreviewLink")]
		public string ContentPreviewLink { get; set; }

		[JsonProperty("createdAt")]
		public DateTimeOffset CreatedAt { get; set; }

		[JsonProperty("discardedAt")]
		public DateTimeOffset DiscardedAt { get; set; }

		[JsonProperty("downloadLink")]
		public string DownloadLink { get; set; }

		[JsonProperty("externalResources")]
		public NexusGraphExternalResource[] ExternalResources { get; set; }

		[JsonProperty("gameVersions")]
		public NexusGraphGameVersion[] GameVersions { get; set; }

		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("installationInfo")]
		public string InstallationInfo { get; set; }

		[JsonProperty("latest")]
		public bool Latest { get; set; }

		[JsonProperty("metadata")]
		public NexusGraphCollectionRevisionMetadata? Metadata { get; set; }

		[JsonProperty("modAuthors")]
		public NexusGraphUserConnection ModAuthors { get; set; }

		[JsonProperty("modCount")]
		public int ModCount { get; set; }

		[JsonProperty("modFiles")]
		public NexusGraphCollectionRevisionMod[] ModFiles { get; set; }

		[JsonProperty("overallRating")]
		public string OverallRating { get; set; }

		[JsonProperty("overallRatingCount")]
		public int OverallRatingCount { get; set; }

		[JsonProperty("retractionReason")]
		public NexusGraphRetractionReason? RetractionReason { get; set; }

		[JsonProperty("revisionNumber")]
		public int RevisionNumber { get; set; }

		[JsonProperty("revisionStatus")]
		public string RevisionStatus { get; set; }

		[JsonProperty("status")]
		public string Status { get; set; }

		[JsonProperty("totalDownloads")]
		public int TotalDownloads { get; set; }

		[JsonProperty("totalSize")]
		public long TotalSize { get; set; }

		[JsonProperty("uniqueDownloads")]
		public int UniqueDownloads { get; set; }

		[JsonProperty("updatedAt")]
		public DateTimeOffset UpdatedAt { get; set; }
	}
}