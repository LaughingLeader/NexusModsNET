using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphRating : INexusGraphNode
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("modelId")]
		public int ModelId { get; set; }

		[JsonProperty("modelType")]
		public string ModelType { get; set; }

		[JsonProperty("rating")]
		public string Rating { get; set; }

		[JsonProperty("userId")]
		public int UserId { get; set; }
	}
}