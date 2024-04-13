namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphNodesFacet
{
	[JsonPropertyName("count")]
	public int Count { get; set; }

	[JsonPropertyName("facet")]
	public string Facet { get; set; }

	[JsonPropertyName("value")]
	public string Value { get; set; }
}