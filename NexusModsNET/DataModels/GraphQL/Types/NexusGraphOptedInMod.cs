namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphOptedInMod
{
	[JsonPropertyName("createdAt")]
	public DateTimeOffset CreatedAt { get; set; }

	[JsonPropertyName("game")]
	public NexusGraphGame? Game { get; set; }

	[JsonPropertyName("gameId")]
	public int GameId { get; set; }

	[JsonPropertyName("id")]
	public int Id { get; set; }

	[JsonPropertyName("mod")]
	public NexusGraphMod? Mod { get; set; }

	[JsonPropertyName("modId")]
	public int ModId { get; set; }

	[JsonPropertyName("ratio")]
	public float Ratio { get; set; }

	[JsonPropertyName("uploader")]
	public NexusGraphUser? Uploader { get; set; }

	[JsonPropertyName("uploaderId")]
	public int UploaderId { get; set; }
}