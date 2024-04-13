namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphReorderItemPayload
{
	[JsonPropertyName("item")]
	public INexusGraphReorderable? Item { get; set; }
}