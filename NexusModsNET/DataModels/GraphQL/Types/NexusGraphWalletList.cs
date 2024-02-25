using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphWalletList
	{
		[JsonProperty("filteredCount")]
		public int FilteredCount { get; set; }

		[JsonProperty("totalCount")]
		public int TotalCount { get; set; }
	}
}