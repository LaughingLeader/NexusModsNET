namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphModFilePage
{
	[JsonPropertyName("nodes")]
	public NexusGraphModFile[] Nodes { get; set; }

	[JsonPropertyName("nodesAggregations")]
	public NexusGraphNodesAggregation[] NodesAggregations { get; set; }

	[JsonPropertyName("nodesCount")]
	public int NodesCount { get; set; }

	[JsonPropertyName("nodesFacets")]
	public NexusGraphNodesFacet[] NodesFacets { get; set; }

	[JsonPropertyName("nodesFilter")]
	public string NodesFilter { get; set; }
}