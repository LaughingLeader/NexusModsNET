using Newtonsoft.Json;

using System;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphCollection
	{
		[JsonProperty("allowUserMedia")]
		public bool AllowUserMedia { get; set; }

		[JsonProperty("bugReport")]
		public NexusGraphCollectionBugReport BugReport { get; set; }

		[JsonProperty("bugReports")]
		public NexusGraphCollectionBugReportConnection BugReports { get; set; }

		[JsonProperty("category")]
		public NexusGraphCategory? Category { get; set; }

		[JsonProperty("collectionChangelogs")]
		public NexusGraphCollectionChangelog[] CollectionChangelogs { get; set; }

		[JsonProperty("collectionStatus")]
		public NexusGraphCollectionStatus? CollectionStatus { get; set; }

		[JsonProperty("commentLink")]
		public string CommentLink { get; set; }

		[JsonProperty("commentThread")]
		public NexusGraphCommentThread CommentThread { get; set; }

		[JsonProperty("createdAt")]
		public DateTimeOffset CreatedAt { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("discardReason")]
		public NexusGraphCollectionDiscardReason? DiscardReason { get; set; }

		[JsonProperty("discardedAt")]
		public DateTimeOffset DiscardedAt { get; set; }

		[JsonProperty("downloadLink")]
		public string DownloadLink { get; set; }

		[JsonProperty("draftRevisionNumber")]
		public int DraftRevisionNumber { get; set; }

		[JsonProperty("endorsements")]
		public int Endorsements { get; set; }

		[JsonProperty("firstPublishedAt")]
		public DateTimeOffset FirstPublishedAt { get; set; }

		[JsonProperty("game")]
		public NexusGraphGame Game { get; set; }

		[JsonProperty("gameId")]
		public int GameId { get; set; }

		[JsonProperty("headerImage")]
		public NexusGraphCollectionImage? HeaderImage { get; set; }

		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("lastPublishedAt")]
		public DateTimeOffset LastPublishedAt { get; set; }

		[JsonProperty("latestPublishedRevision")]
		public NexusGraphCollectionRevision? LatestPublishedRevision { get; set; }

		[JsonProperty("latestPublishedRevisionRating")]
		public string LatestPublishedRevisionRating { get; set; }

		[JsonProperty("listedAt")]
		public DateTimeOffset ListedAt { get; set; }

		[JsonProperty("manuallyVerifyMedia")]
		public bool ManuallyVerifyMedia { get; set; }

		[JsonProperty("media")]
		public object[] Media { get; set; }

		[JsonProperty("metadata")]
		public NexusGraphCollectionMetadata? Metadata { get; set; }

		[JsonProperty("moderations")]
		public NexusGraphModeration[] Moderations { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("overallRating")]
		public string OverallRating { get; set; }

		[JsonProperty("overallRatingCount")]
		public int OverallRatingCount { get; set; }

		[JsonProperty("permissions")]
		public NexusGraphPermission[] Permissions { get; set; }

		[JsonProperty("publicRevisions")]
		public NexusGraphPublicCollectionRevision[] PublicRevisions { get; set; }

		[JsonProperty("recentRating")]
		public string RecentRating { get; set; }

		[JsonProperty("recentRatingCount")]
		public int RecentRatingCount { get; set; }

		[JsonProperty("revisions")]
		public NexusGraphCollectionRevision[] Revisions { get; set; }

		[JsonProperty("slug")]
		public string Slug { get; set; }

		[JsonProperty("summary")]
		public string Summary { get; set; }

		[JsonProperty("tags")]
		public NexusGraphTag[] Tags { get; set; }

		[JsonProperty("tileImage")]
		public NexusGraphCollectionImage? TileImage { get; set; }

		[JsonProperty("totalDownloads")]
		public int TotalDownloads { get; set; }

		[JsonProperty("uniqueDownloads")]
		public int UniqueDownloads { get; set; }

		[JsonProperty("updatedAt")]
		public DateTimeOffset UpdatedAt { get; set; }

		[JsonProperty("user")]
		public NexusGraphUser User { get; set; }

		[JsonProperty("userId")]
		public int UserId { get; set; }
	}
}