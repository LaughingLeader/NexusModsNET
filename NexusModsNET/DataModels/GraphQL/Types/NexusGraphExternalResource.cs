namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphExternalResource
{
	[JsonPropertyName("author")]
	public string Author { get; set; }

	[JsonPropertyName("collectionRevisionId")]
	public int CollectionRevisionId { get; set; }

	[JsonPropertyName("fileExpression")]
	public string FileExpression { get; set; }

	[JsonPropertyName("id")]
	public int Id { get; set; }

	[JsonPropertyName("name")]
	public string Name { get; set; }

	[JsonPropertyName("optional")]
	public bool Optional { get; set; }

	[JsonPropertyName("resourceType")]
	public string ResourceType { get; set; }

	[JsonPropertyName("resourceUrl")]
	public string ResourceUrl { get; set; }

	[JsonPropertyName("version")]
	public string Version { get; set; }
}