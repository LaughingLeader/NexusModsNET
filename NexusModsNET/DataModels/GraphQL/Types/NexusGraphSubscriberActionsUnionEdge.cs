namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphSubscriberActionsUnionEdge
{
	[JsonPropertyName("cursor")]
	public string Cursor { get; set; }

	[JsonPropertyName("node")]
	public object? Node { get; set; }
}