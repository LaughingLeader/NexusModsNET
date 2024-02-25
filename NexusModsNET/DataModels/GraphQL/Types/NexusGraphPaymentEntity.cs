using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphPaymentEntity
	{
		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("label")]
		public string Label { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }
	}
}