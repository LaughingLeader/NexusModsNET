using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphCreateRatingMutationPayload
	{
		[JsonProperty("averageRating")]
		public NexusGraphAverageRating AverageRating { get; set; }

		[JsonProperty("rating")]
		public NexusGraphRating Rating { get; set; }

		[JsonProperty("success")]
		public bool Success { get; set; }
	}
}