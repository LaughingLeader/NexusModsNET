namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphModConnection
{
	[JsonPropertyName("edges")]
	public NexusGraphModEdge[] Edges { get; set; }

	[JsonPropertyName("nodes")]
	public NexusGraphMod[] Nodes { get; set; }

	[JsonPropertyName("pageInfo")]
	public NexusGraphPageInfo PageInfo { get; set; }

	[JsonPropertyName("totalCount")]
	public int TotalCount { get; set; }
}