namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphModEndorserEdge
{
	[JsonPropertyName("cursor")]
	public string Cursor { get; set; }

	[JsonPropertyName("endorsedAt")]
	public DateTimeOffset EndorsedAt { get; set; }

	[JsonPropertyName("node")]
	public NexusGraphUser? Node { get; set; }
}