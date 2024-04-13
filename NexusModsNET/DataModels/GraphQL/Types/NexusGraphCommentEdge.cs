namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphCommentEdge
{
	[JsonPropertyName("cursor")]
	public string Cursor { get; set; }

	[JsonPropertyName("node")]
	public NexusGraphComment? Node { get; set; }
}