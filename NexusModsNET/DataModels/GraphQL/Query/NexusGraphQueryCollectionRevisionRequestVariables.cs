using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Query
{
	public class NexusGraphQueryCollectionRevisionRequestVariables
	{
		[JsonProperty("domain")]
		public string Domain { get; set; }

		[JsonProperty("slug")]
		public string Slug { get; set; }

		[JsonProperty("revision")]
		public long Revision { get; set; }

		[JsonProperty("viewAdultContent")]
		public bool ViewAdultContent { get; set; }
	}
}
