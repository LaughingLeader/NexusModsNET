namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphMod
{
	[JsonPropertyName("adultContent")]
	public bool AdultContent { get; set; }

	[JsonPropertyName("author")]
	public string Author { get; set; }

	[JsonPropertyName("category")]
	public string Category { get; set; }

	[JsonPropertyName("createdAt")]
	public DateTimeOffset CreatedAt { get; set; }

	[JsonPropertyName("description")]
	public string Description { get; set; }

	[JsonPropertyName("downloads")]
	public int Downloads { get; set; }

	[JsonPropertyName("endorsements")]
	public int Endorsements { get; set; }

	[JsonPropertyName("game")]
	public NexusGraphGame Game { get; set; }

	[JsonPropertyName("gameId")]
	public int GameId { get; set; }

	[JsonPropertyName("id")]
	public string Id { get; set; }

	[JsonPropertyName("modCategory")]
	public NexusGraphModCategory ModCategory { get; set; }

	[JsonPropertyName("modId")]
	public int ModId { get; set; }

	[JsonPropertyName("name")]
	public string Name { get; set; }

	[JsonPropertyName("pictureUrl")]
	public string PictureUrl { get; set; }

	[JsonPropertyName("status")]
	public string Status { get; set; }

	[JsonPropertyName("summary")]
	public string Summary { get; set; }

	[JsonPropertyName("thumbnailUrl")]
	public string ThumbnailUrl { get; set; }

	[JsonPropertyName("uid")]
	public string Uid { get; set; }

	[JsonPropertyName("updatedAt")]
	public DateTimeOffset UpdatedAt { get; set; }

	[JsonPropertyName("uploader")]
	public NexusGraphUser Uploader { get; set; }

	[JsonPropertyName("version")]
	public string Version { get; set; }
}