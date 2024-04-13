namespace NexusModsNET.DataModels.GraphQL.Types;

public interface INexusGraphReorderable
{
	[JsonPropertyName("order")]
	public string Order { get; set; }
}