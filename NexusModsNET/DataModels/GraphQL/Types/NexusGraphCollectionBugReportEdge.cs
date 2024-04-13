namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphCollectionBugReportEdge
{
	[JsonPropertyName("cursor")]
	public string Cursor { get; set; }

	[JsonPropertyName("node")]
	public NexusGraphCollectionBugReport? Node { get; set; }
}