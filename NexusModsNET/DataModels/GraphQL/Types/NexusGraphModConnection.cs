using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphModConnection
	{
		[JsonProperty("edges")]
		public NexusGraphModEdge[] Edges { get; set; }

		[JsonProperty("nodes")]
		public NexusGraphMod[] Nodes { get; set; }

		[JsonProperty("pageInfo")]
		public NexusGraphPageInfo PageInfo { get; set; }

		[JsonProperty("totalCount")]
		public int TotalCount { get; set; }
	}
}