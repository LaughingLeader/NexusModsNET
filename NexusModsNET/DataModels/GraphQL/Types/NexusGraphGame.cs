using Newtonsoft.Json;

using System;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphGame
	{
		[JsonProperty("approvedAt")]
		public DateTimeOffset ApprovedAt { get; set; }

		[JsonProperty("availableTags")]
		public NexusGraphTag[] AvailableTags { get; set; }

		[JsonProperty("collectionCount")]
		public int CollectionCount { get; set; }

		[JsonProperty("domainName")]
		public string DomainName { get; set; }

		[JsonProperty("downloadCount")]
		public int DownloadCount { get; set; }

		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("imageCount")]
		public int ImageCount { get; set; }

		[JsonProperty("mediaCount")]
		public int MediaCount { get; set; }

		[JsonProperty("modCount")]
		public int ModCount { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("specificTags")]
		public NexusGraphTag[] SpecificTags { get; set; }

		[JsonProperty("supporterImageCount")]
		public int SupporterImageCount { get; set; }

		[JsonProperty("tileImageUrl")]
		public string TileImageUrl { get; set; }

		[JsonProperty("uniqueDownloadCount")]
		public int UniqueDownloadCount { get; set; }

		[JsonProperty("videoCount")]
		public int VideoCount { get; set; }
	}
}