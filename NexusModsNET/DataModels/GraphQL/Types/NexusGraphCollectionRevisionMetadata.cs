using Newtonsoft.Json;

using System;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphCollectionRevisionMetadata
	{
		[JsonProperty("downloadedAt")]
		public DateTimeOffset DownloadedAt { get; set; }

		[JsonProperty("ratingValue")]
		public NexusGraphRatingOptions? RatingValue { get; set; }
	}
}