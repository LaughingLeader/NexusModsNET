using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL
{
	public class NexusGraphTileImage
	{
		[JsonProperty("url")]
		public string Url { get; set; }

		[JsonProperty("altText")]
		public string AltText { get; set; }

		[JsonProperty("thumbnailUrl")]
		public string ThumbnailUrl { get; set; }
	}
}