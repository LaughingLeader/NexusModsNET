namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphCommentSearchResultEdge
{
	[JsonPropertyName("cursor")]
	public string Cursor { get; set; }

	[JsonPropertyName("node")]
	public NexusGraphComment? Node { get; set; }

	[JsonPropertyName("relevance")]
	public float Relevance { get; set; }
}