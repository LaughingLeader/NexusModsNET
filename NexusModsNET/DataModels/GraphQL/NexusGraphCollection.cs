using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL
{
	public class NexusGraphCollection
	{
		[JsonProperty("id")]
		public long Id { get; set; }

		[JsonProperty("slug")]
		public string Slug { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("summary")]
		public string Summary { get; set; }

		[JsonProperty("adultContent")]
		public bool AdultContent { get; set; }

		[JsonProperty("overallRating")]
		public string OverallRating { get; set; }

		[JsonProperty("overallRatingCount")]
		public int OverallRatingCount { get; set; }

		[JsonProperty("endorsements")]
		public int Endorsements { get; set; }

		[JsonProperty("totalDownloads")]
		public int TotalDownloads { get; set; }

		[JsonProperty("draftRevisionNumber")]
		public int? DraftRevisionNumber { get; set; }

		[JsonProperty("latestPublishedRevision")]
		public NexusGraphLatestPublishedRevision LatestPublishedRevision { get; set; }

		[JsonProperty("category")]
		public NexusGraphCategory Category { get; set; }

		[JsonProperty("game")]
		public NexusGraphGame Game { get; set; }

		[JsonProperty("user")]
		public NexusGraphUser User { get; set; }

		[JsonProperty("tileImage")]
		public NexusGraphTileImage TileImage { get; set; }
	}
}