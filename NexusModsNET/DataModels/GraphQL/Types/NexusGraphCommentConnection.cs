using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphCommentConnection
	{
		[JsonProperty("edges")]
		public NexusGraphCommentEdge[] Edges { get; set; }

		[JsonProperty("nodes")]
		public NexusGraphComment[] Nodes { get; set; }

		[JsonProperty("pageInfo")]
		public NexusGraphPageInfo PageInfo { get; set; }

		[JsonProperty("totalCount")]
		public int TotalCount { get; set; }
	}
}