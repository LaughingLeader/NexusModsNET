using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphSubscriberActionsUnionConnection
	{
		[JsonProperty("edges")]
		public NexusGraphSubscriberActionsUnionEdge[] Edges { get; set; }

		[JsonProperty("nodes")]
		public object[] Nodes { get; set; }

		[JsonProperty("pageInfo")]
		public NexusGraphPageInfo PageInfo { get; set; }

		[JsonProperty("totalCount")]
		public int TotalCount { get; set; }
	}
}