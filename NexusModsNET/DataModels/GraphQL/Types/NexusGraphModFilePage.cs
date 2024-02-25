using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphModFilePage
	{
		[JsonProperty("nodes")]
		public NexusGraphModFile[] Nodes { get; set; }

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