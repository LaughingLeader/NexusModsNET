using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphCommentSearchResultConnection
	{
		[JsonProperty("edges")]
		public NexusGraphCommentSearchResultEdge[] Edges { get; set; }

		[JsonProperty("nodes")]
		public NexusGraphComment[] Nodes { get; set; }

		[JsonProperty("pageInfo")]
		public NexusGraphPageInfo PageInfo { get; set; }

		[JsonProperty("timeTaken")]
		public int TimeTaken { get; set; }

		[JsonProperty("totalCount")]
		public int TotalCount { get; set; }
	}
}