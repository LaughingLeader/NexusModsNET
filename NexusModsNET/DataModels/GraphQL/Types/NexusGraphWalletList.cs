namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphWalletList
{
	[JsonPropertyName("filteredCount")]
	public int FilteredCount { get; set; }

	[JsonPropertyName("totalCount")]
	public int TotalCount { get; set; }
}