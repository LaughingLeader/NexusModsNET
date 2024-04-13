namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphUserEdge
{
	[JsonPropertyName("cursor")]
	public string Cursor { get; set; }

	[JsonPropertyName("node")]
	public NexusGraphUser? Node { get; set; }
}