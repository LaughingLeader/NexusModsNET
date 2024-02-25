using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphModPage
	{
		[JsonProperty("nodes")]
		public NexusGraphMod[] Nodes { get; set; }

		[JsonProperty("nodesAggregations")]
		public NexusGraphNodesAggregation[] NodesAggregations { get; set; }

		[JsonProperty("nodesCount")]
		public int NodesCount { get; set; }

		[JsonProperty("nodesFacets")]
		public NexusGraphNodesFacet[] NodesFacets { get; set; }

		[JsonProperty("nodesFilter")]
		public string NodesFilter { get; set; }
	}
}