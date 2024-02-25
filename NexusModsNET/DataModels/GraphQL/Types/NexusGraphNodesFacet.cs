using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphNodesFacet
	{
		[JsonProperty("count")]
		public int Count { get; set; }

		[JsonProperty("facet")]
		public string Facet { get; set; }

		[JsonProperty("value")]
		public string Value { get; set; }
	}
}