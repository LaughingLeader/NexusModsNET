namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphCollectionRevisionMod
{
	[JsonPropertyName("collectionRevisionId")]
	public int CollectionRevisionId { get; set; }

	[JsonPropertyName("file")]
	public NexusGraphModFile? File { get; set; }

	[JsonPropertyName("fileId")]
	public int FileId { get; set; }

	[JsonPropertyName("gameId")]
	public int GameId { get; set; }

	[JsonPropertyName("id")]
	public string Id { get; set; }

	[JsonPropertyName("optional")]
	public bool Optional { get; set; }

	[JsonPropertyName("updatePolicy")]
	public string UpdatePolicy { get; set; }

	[JsonPropertyName("version")]
	public string Version { get; set; }
}