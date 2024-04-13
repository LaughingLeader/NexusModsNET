namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphFileHash
{
	[JsonPropertyName("createdAt")]
	public DateTimeOffset CreatedAt { get; set; }

	[JsonPropertyName("fileName")]
	public string FileName { get; set; }

	[JsonPropertyName("fileSize")]
	public long FileSize { get; set; }

	[JsonPropertyName("fileType")]
	public string FileType { get; set; }

	[JsonPropertyName("gameId")]
	public int GameId { get; set; }

	[JsonPropertyName("md5")]
	public string Md5 { get; set; }

	[JsonPropertyName("modFile")]
	public NexusGraphModFile? ModFile { get; set; }

	[JsonPropertyName("modFileId")]
	public int ModFileId { get; set; }
}