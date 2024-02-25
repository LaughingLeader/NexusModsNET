using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphNodesAggregation
	{
		[JsonProperty("key")]
		public string Key { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("sub")]
		public NexusGraphNodesAggregation[] Sub { get; set; }

		[JsonProperty("value")]
		public int Value { get; set; }
	}
}