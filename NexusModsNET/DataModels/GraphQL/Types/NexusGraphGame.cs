namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphGame
{
	[JsonPropertyName("approvedAt")]
	public DateTimeOffset ApprovedAt { get; set; }

	[JsonPropertyName("availableTags")]
	public NexusGraphTag[] AvailableTags { get; set; }

	[JsonPropertyName("collectionCount")]
	public int CollectionCount { get; set; }

	[JsonPropertyName("domainName")]
	public string DomainName { get; set; }

	[JsonPropertyName("downloadCount")]
	public int DownloadCount { get; set; }

	[JsonPropertyName("id")]
	public int Id { get; set; }

	[JsonPropertyName("imageCount")]
	public int ImageCount { get; set; }

	[JsonPropertyName("mediaCount")]
	public int MediaCount { get; set; }

	[JsonPropertyName("modCount")]
	public int ModCount { get; set; }

	[JsonPropertyName("name")]
	public string Name { get; set; }

	[JsonPropertyName("specificTags")]
	public NexusGraphTag[] SpecificTags { get; set; }

	[JsonPropertyName("supporterImageCount")]
	public int SupporterImageCount { get; set; }

	[JsonPropertyName("tileImageUrl")]
	public string TileImageUrl { get; set; }

	[JsonPropertyName("uniqueDownloadCount")]
	public int UniqueDownloadCount { get; set; }

	[JsonPropertyName("videoCount")]
	public int VideoCount { get; set; }
}