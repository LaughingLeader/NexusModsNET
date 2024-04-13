namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphEndorsement
{
	[JsonPropertyName("modelId")]
	public int ModelId { get; set; }

	[JsonPropertyName("modelType")]
	public int ModelType { get; set; }

	[JsonPropertyName("status")]
	public string Status { get; set; }

	[JsonPropertyName("userId")]
	public int UserId { get; set; }
}