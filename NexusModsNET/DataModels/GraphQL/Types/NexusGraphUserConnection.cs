using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphUserConnection
	{
		[JsonProperty("edges")]
		public NexusGraphUserEdge[] Edges { get; set; }

		[JsonProperty("nodes")]
		public NexusGraphUser[] Nodes { get; set; }

		[JsonProperty("pageInfo")]
		public NexusGraphPageInfo PageInfo { get; set; }

		[JsonProperty("totalCount")]
		public int TotalCount { get; set; }
	}
}