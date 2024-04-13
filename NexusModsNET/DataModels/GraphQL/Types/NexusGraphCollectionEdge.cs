namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphCollectionEdge
{
	[JsonPropertyName("cursor")]
	public string Cursor { get; set; }

	[JsonPropertyName("node")]
	public NexusGraphCollection? Node { get; set; }
}