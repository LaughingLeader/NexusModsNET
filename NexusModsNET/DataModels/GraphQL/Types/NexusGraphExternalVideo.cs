namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphExternalVideo
{
	[JsonPropertyName("embedUrl")]
	public string EmbedUrl { get; set; }

	[JsonPropertyName("id")]
	public string Id { get; set; }

	[JsonPropertyName("platform")]
	public NexusGraphExternalVideoPlatform Platform { get; set; }

	[JsonPropertyName("thumbnailUrl")]
	public string ThumbnailUrl { get; set; }

	[JsonPropertyName("title")]
	public string Title { get; set; }
}