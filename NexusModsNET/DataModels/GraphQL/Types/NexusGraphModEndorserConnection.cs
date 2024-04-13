namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphModEndorserConnection
{
	[JsonPropertyName("edges")]
	public NexusGraphModEndorserEdge[] Edges { get; set; }

	[JsonPropertyName("nodes")]
	public NexusGraphUser[] Nodes { get; set; }

	[JsonPropertyName("pageInfo")]
	public NexusGraphPageInfo PageInfo { get; set; }
}