using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphTransaction
	{
		[JsonProperty("amount")]
		public int Amount { get; set; }

		[JsonProperty("createdAt")]
		public string CreatedAt { get; set; }

		[JsonProperty("creditorEntity")]
		public NexusGraphPaymentEntity? CreditorEntity { get; set; }

		[JsonProperty("debitorEntity")]
		public NexusGraphPaymentEntity? DebitorEntity { get; set; }

		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("label")]
		public string Label { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }
	}
}