namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphCollection
{
	[JsonPropertyName("allowUserMedia")]
	public bool AllowUserMedia { get; set; }

	[JsonPropertyName("bugReport")]
	public NexusGraphCollectionBugReport BugReport { get; set; }

	[JsonPropertyName("bugReports")]
	public NexusGraphCollectionBugReportConnection BugReports { get; set; }

	[JsonPropertyName("category")]
	public NexusGraphCategory? Category { get; set; }

	[JsonPropertyName("collectionChangelogs")]
	public NexusGraphCollectionChangelog[] CollectionChangelogs { get; set; }

	[JsonPropertyName("collectionStatus")]
	public NexusGraphCollectionStatus? CollectionStatus { get; set; }

	[JsonPropertyName("commentLink")]
	public string CommentLink { get; set; }

	[JsonPropertyName("commentThread")]
	public NexusGraphCommentThread CommentThread { get; set; }

	[JsonPropertyName("createdAt")]
	public DateTimeOffset CreatedAt { get; set; }

	[JsonPropertyName("description")]
	public string Description { get; set; }

	[JsonPropertyName("discardReason")]
	public NexusGraphCollectionDiscardReason? DiscardReason { get; set; }

	[JsonPropertyName("discardedAt")]
	public DateTimeOffset DiscardedAt { get; set; }

	[JsonPropertyName("downloadLink")]
	public string DownloadLink { get; set; }

	[JsonPropertyName("draftRevisionNumber")]
	public int DraftRevisionNumber { get; set; }

	[JsonPropertyName("endorsements")]
	public int Endorsements { get; set; }

	[JsonPropertyName("firstPublishedAt")]
	public DateTimeOffset FirstPublishedAt { get; set; }

	[JsonPropertyName("game")]
	public NexusGraphGame Game { get; set; }

	[JsonPropertyName("gameId")]
	public int GameId { get; set; }

	[JsonPropertyName("headerImage")]
	public NexusGraphCollectionImage? HeaderImage { get; set; }

	[JsonPropertyName("id")]
	public int Id { get; set; }

	[JsonPropertyName("lastPublishedAt")]
	public DateTimeOffset LastPublishedAt { get; set; }

	[JsonPropertyName("latestPublishedRevision")]
	public NexusGraphCollectionRevision? LatestPublishedRevision { get; set; }

	[JsonPropertyName("latestPublishedRevisionRating")]
	public string LatestPublishedRevisionRating { get; set; }

	[JsonPropertyName("listedAt")]
	public DateTimeOffset ListedAt { get; set; }

	[JsonPropertyName("manuallyVerifyMedia")]
	public bool ManuallyVerifyMedia { get; set; }

	[JsonPropertyName("media")]
	public object[] Media { get; set; }

	[JsonPropertyName("metadata")]
	public NexusGraphCollectionMetadata? Metadata { get; set; }

	[JsonPropertyName("moderations")]
	public NexusGraphModeration[] Moderations { get; set; }

	[JsonPropertyName("name")]
	public string Name { get; set; }

	[JsonPropertyName("overallRating")]
	public string OverallRating { get; set; }

	[JsonPropertyName("overallRatingCount")]
	public int OverallRatingCount { get; set; }

	[JsonPropertyName("permissions")]
	public NexusGraphPermission[] Permissions { get; set; }

	[JsonPropertyName("publicRevisions")]
	public NexusGraphPublicCollectionRevision[] PublicRevisions { get; set; }

	[JsonPropertyName("recentRating")]
	public string RecentRating { get; set; }

	[JsonPropertyName("recentRatingCount")]
	public int RecentRatingCount { get; set; }

	[JsonPropertyName("revisions")]
	public NexusGraphCollectionRevision[] Revisions { get; set; }

	[JsonPropertyName("slug")]
	public string Slug { get; set; }

	[JsonPropertyName("summary")]
	public string Summary { get; set; }

	[JsonPropertyName("tags")]
	public NexusGraphTag[] Tags { get; set; }

	[JsonPropertyName("tileImage")]
	public NexusGraphCollectionImage? TileImage { get; set; }

	[JsonPropertyName("totalDownloads")]
	public int TotalDownloads { get; set; }

	[JsonPropertyName("uniqueDownloads")]
	public int UniqueDownloads { get; set; }

	[JsonPropertyName("updatedAt")]
	public DateTimeOffset UpdatedAt { get; set; }

	[JsonPropertyName("user")]
	public NexusGraphUser User { get; set; }

	[JsonPropertyName("userId")]
	public int UserId { get; set; }
}