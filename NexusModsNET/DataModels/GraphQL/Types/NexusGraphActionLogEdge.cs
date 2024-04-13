namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphActionLogEdge
{
	[JsonPropertyName("cursor")]
	public string Cursor { get; set; }

	[JsonPropertyName("node")]
	public NexusGraphActionLog? Node { get; set; }
}