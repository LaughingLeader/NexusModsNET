namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphCommentSearchResultConnection
{
	[JsonPropertyName("edges")]
	public NexusGraphCommentSearchResultEdge[] Edges { get; set; }

	[JsonPropertyName("nodes")]
	public NexusGraphComment[] Nodes { get; set; }

	[JsonPropertyName("pageInfo")]
	public NexusGraphPageInfo PageInfo { get; set; }

	[JsonPropertyName("timeTaken")]
	public int TimeTaken { get; set; }

	[JsonPropertyName("totalCount")]
	public int TotalCount { get; set; }
}