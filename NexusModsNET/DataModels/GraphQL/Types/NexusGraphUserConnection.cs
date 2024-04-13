namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphUserConnection
{
	[JsonPropertyName("edges")]
	public NexusGraphUserEdge[] Edges { get; set; }

	[JsonPropertyName("nodes")]
	public NexusGraphUser[] Nodes { get; set; }

	[JsonPropertyName("pageInfo")]
	public NexusGraphPageInfo PageInfo { get; set; }

	[JsonPropertyName("totalCount")]
	public int TotalCount { get; set; }
}