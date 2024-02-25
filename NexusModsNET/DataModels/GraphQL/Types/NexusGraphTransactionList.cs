using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphTransactionList
	{
		[JsonProperty("filteredCount")]
		public int FilteredCount { get; set; }

		[JsonProperty("totalCount")]
		public int TotalCount { get; set; }

		[JsonProperty("transactions")]
		public NexusGraphTransaction[] Transactions { get; set; }
	}
}