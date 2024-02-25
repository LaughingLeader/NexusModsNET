using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphEndorsement
	{
		[JsonProperty("modelId")]
		public int ModelId { get; set; }

		[JsonProperty("modelType")]
		public int ModelType { get; set; }

		[JsonProperty("status")]
		public string Status { get; set; }

		[JsonProperty("userId")]
		public int UserId { get; set; }
	}
}