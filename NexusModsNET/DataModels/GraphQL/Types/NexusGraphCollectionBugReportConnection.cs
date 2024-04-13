namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphCollectionBugReportConnection
{
	[JsonPropertyName("edges")]
	public NexusGraphCollectionBugReportEdge[] Edges { get; set; }

	[JsonPropertyName("nodes")]
	public NexusGraphCollectionBugReport[] Nodes { get; set; }

	[JsonPropertyName("pageInfo")]
	public NexusGraphPageInfo PageInfo { get; set; }

	[JsonPropertyName("totalCount")]
	public int TotalCount { get; set; }
}