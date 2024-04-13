namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphPageInfo
{
	[JsonPropertyName("endCursor")]
	public string EndCursor { get; set; }

	[JsonPropertyName("hasNextPage")]
	public bool HasNextPage { get; set; }

	[JsonPropertyName("hasPreviousPage")]
	public bool HasPreviousPage { get; set; }

	[JsonPropertyName("startCursor")]
	public string StartCursor { get; set; }
}