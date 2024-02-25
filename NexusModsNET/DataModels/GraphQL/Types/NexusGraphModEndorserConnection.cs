using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphModEndorserConnection
	{
		[JsonProperty("edges")]
		public NexusGraphModEndorserEdge[] Edges { get; set; }

		[JsonProperty("nodes")]
		public NexusGraphUser[] Nodes { get; set; }

		[JsonProperty("pageInfo")]
		public NexusGraphPageInfo PageInfo { get; set; }
	}
}