namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphActionLogConnection
{
	[JsonPropertyName("edges")]
	public NexusGraphActionLogEdge[] Edges { get; set; }

	[JsonPropertyName("nodes")]
	public NexusGraphActionLog[] Nodes { get; set; }

	[JsonPropertyName("pageInfo")]
	public NexusGraphPageInfo PageInfo { get; set; }

	[JsonPropertyName("totalCount")]
	public int TotalCount { get; set; }
}