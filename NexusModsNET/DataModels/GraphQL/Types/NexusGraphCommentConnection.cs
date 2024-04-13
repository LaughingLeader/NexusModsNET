namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphCommentConnection
{
	[JsonPropertyName("edges")]
	public NexusGraphCommentEdge[] Edges { get; set; }

	[JsonPropertyName("nodes")]
	public NexusGraphComment[] Nodes { get; set; }

	[JsonPropertyName("pageInfo")]
	public NexusGraphPageInfo PageInfo { get; set; }

	[JsonPropertyName("totalCount")]
	public int TotalCount { get; set; }
}