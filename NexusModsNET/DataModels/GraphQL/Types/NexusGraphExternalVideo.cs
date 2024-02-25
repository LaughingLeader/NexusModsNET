using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphExternalVideo
	{
		[JsonProperty("embedUrl")]
		public string EmbedUrl { get; set; }

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("platform")]
		public NexusGraphExternalVideoPlatform Platform { get; set; }

		[JsonProperty("thumbnailUrl")]
		public string ThumbnailUrl { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }
	}
}