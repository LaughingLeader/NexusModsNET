using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphAverageRating
	{
		[JsonProperty("average")]
		public float Average { get; set; }

		[JsonProperty("positive")]
		public int Positive { get; set; }

		[JsonProperty("total")]
		public int Total { get; set; }
	}
}