using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphPageInfo
	{
		[JsonProperty("endCursor")]
		public string EndCursor { get; set; }

		[JsonProperty("hasNextPage")]
		public bool HasNextPage { get; set; }

		[JsonProperty("hasPreviousPage")]
		public bool HasPreviousPage { get; set; }

		[JsonProperty("startCursor")]
		public string StartCursor { get; set; }
	}
}