namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphTransaction
{
	[JsonPropertyName("amount")]
	public int Amount { get; set; }

	[JsonPropertyName("createdAt")]
	public string CreatedAt { get; set; }

	[JsonPropertyName("creditorEntity")]
	public NexusGraphPaymentEntity? CreditorEntity { get; set; }

	[JsonPropertyName("debitorEntity")]
	public NexusGraphPaymentEntity? DebitorEntity { get; set; }

	[JsonPropertyName("id")]
	public int Id { get; set; }

	[JsonPropertyName("label")]
	public string Label { get; set; }

	[JsonPropertyName("type")]
	public string Type { get; set; }
}