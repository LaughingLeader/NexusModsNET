using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphActionLogConnection
	{
		[JsonProperty("edges")]
		public NexusGraphActionLogEdge[] Edges { get; set; }

		[JsonProperty("nodes")]
		public NexusGraphActionLog[] Nodes { get; set; }

		[JsonProperty("pageInfo")]
		public NexusGraphPageInfo PageInfo { get; set; }

		[JsonProperty("totalCount")]
		public int TotalCount { get; set; }
	}
}