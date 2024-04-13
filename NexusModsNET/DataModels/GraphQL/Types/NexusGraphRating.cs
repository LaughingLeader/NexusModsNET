namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphRating : INexusGraphNode
{
	[JsonPropertyName("id")]
	public string Id { get; set; }

	[JsonPropertyName("modelId")]
	public int ModelId { get; set; }

	[JsonPropertyName("modelType")]
	public string ModelType { get; set; }

	[JsonPropertyName("rating")]
	public string Rating { get; set; }

	[JsonPropertyName("userId")]
	public int UserId { get; set; }
}