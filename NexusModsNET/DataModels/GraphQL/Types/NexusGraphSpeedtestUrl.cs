using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphSpeedtestUrl
	{
		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("location")]
		public string Location { get; set; }

		[JsonProperty("tag")]
		public string Tag { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }
	}
}