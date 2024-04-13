namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphCollectionConnection
{
	[JsonPropertyName("edges")]
	public NexusGraphCollectionEdge[] Edges { get; set; }

	[JsonPropertyName("facets")]
	public NexusGraphNodesFacet[] Facets { get; set; }

	[JsonPropertyName("nodes")]
	public NexusGraphCollection[] Nodes { get; set; }

	[JsonPropertyName("pageInfo")]
	public NexusGraphPageInfo PageInfo { get; set; }

	[JsonPropertyName("totalCount")]
	public int TotalCount { get; set; }
}