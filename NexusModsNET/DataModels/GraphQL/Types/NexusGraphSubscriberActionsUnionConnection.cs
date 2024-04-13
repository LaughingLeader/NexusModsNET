namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphSubscriberActionsUnionConnection
{
	[JsonPropertyName("edges")]
	public NexusGraphSubscriberActionsUnionEdge[] Edges { get; set; }

	[JsonPropertyName("nodes")]
	public object[] Nodes { get; set; }

	[JsonPropertyName("pageInfo")]
	public NexusGraphPageInfo PageInfo { get; set; }

	[JsonPropertyName("totalCount")]
	public int TotalCount { get; set; }
}