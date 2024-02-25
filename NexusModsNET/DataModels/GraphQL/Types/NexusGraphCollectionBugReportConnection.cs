using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphCollectionBugReportConnection
	{
		[JsonProperty("edges")]
		public NexusGraphCollectionBugReportEdge[] Edges { get; set; }

		[JsonProperty("nodes")]
		public NexusGraphCollectionBugReport[] Nodes { get; set; }

		[JsonProperty("pageInfo")]
		public NexusGraphPageInfo PageInfo { get; set; }

		[JsonProperty("totalCount")]
		public int TotalCount { get; set; }
	}
}