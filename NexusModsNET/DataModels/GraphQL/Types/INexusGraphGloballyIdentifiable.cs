namespace NexusModsNET.DataModels.GraphQL.Types;

public interface INexusGraphGloballyIdentifiable
{
	[JsonPropertyName("globalId")]
	public string GlobalId { get; set; }

	[JsonPropertyName("id")]
	public string Id { get; set; }
}