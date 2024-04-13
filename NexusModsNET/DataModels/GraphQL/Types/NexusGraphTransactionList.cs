namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphTransactionList
{
	[JsonPropertyName("filteredCount")]
	public int FilteredCount { get; set; }

	[JsonPropertyName("totalCount")]
	public int TotalCount { get; set; }

	[JsonPropertyName("transactions")]
	public NexusGraphTransaction[] Transactions { get; set; }
}