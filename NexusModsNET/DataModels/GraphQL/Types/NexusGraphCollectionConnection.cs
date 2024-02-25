using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphCollectionConnection
	{
		[JsonProperty("edges")]
		public NexusGraphCollectionEdge[] Edges { get; set; }

		[JsonProperty("facets")]
		public NexusGraphNodesFacet[] Facets { get; set; }

		[JsonProperty("nodes")]
		public NexusGraphCollection[] Nodes { get; set; }

		[JsonProperty("pageInfo")]
		public NexusGraphPageInfo PageInfo { get; set; }

		[JsonProperty("totalCount")]
		public int TotalCount { get; set; }
	}
}