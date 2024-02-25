using Newtonsoft.Json;

using System;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphCollectionImage : INexusGraphGloballyIdentifiable, INexusGraphReorderable
	{
		[JsonProperty("altText")]
		public string AltText { get; set; }

		[JsonProperty("collection")]
		public NexusGraphCollection Collection { get; set; }

		[JsonProperty("createdAt")]
		public DateTimeOffset CreatedAt { get; set; }

		[JsonProperty("discardedAt")]
		public DateTimeOffset DiscardedAt { get; set; }

		[JsonProperty("globalId")]
		public string GlobalId { get; set; }

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("imageType")]
		public NexusGraphImageTypes ImageType { get; set; }

		[JsonProperty("order")]
		public string Order { get; set; }

		[JsonProperty("revision")]
		public NexusGraphCollectionRevision? Revision { get; set; }

		[JsonProperty("thumbnailUrl")]
		public string ThumbnailUrl { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }

		[JsonProperty("updatedAt")]
		public DateTimeOffset UpdatedAt { get; set; }

		[JsonProperty("url")]
		public string Url { get; set; }

		[JsonProperty("user")]
		public NexusGraphUser User { get; set; }
	}
}