namespace NexusModsNET.DataModels.GraphQL.Types;

public interface INexusGraphNode
{
	[JsonPropertyName("id")]
	public string Id { get; set; }
}