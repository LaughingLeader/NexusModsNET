namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphModEdge
{
	[JsonPropertyName("cursor")]
	public string Cursor { get; set; }

	[JsonPropertyName("node")]
	public NexusGraphMod? Node { get; set; }
}