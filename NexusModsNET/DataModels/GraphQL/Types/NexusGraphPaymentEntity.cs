namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphPaymentEntity
{
	[JsonPropertyName("id")]
	public int Id { get; set; }

	[JsonPropertyName("label")]
	public string Label { get; set; }

	[JsonPropertyName("type")]
	public string Type { get; set; }
}