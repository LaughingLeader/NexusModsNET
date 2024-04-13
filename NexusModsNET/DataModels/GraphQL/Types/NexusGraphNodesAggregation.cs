namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphNodesAggregation
{
	[JsonPropertyName("key")]
	public string Key { get; set; }

	[JsonPropertyName("name")]
	public string Name { get; set; }

	[JsonPropertyName("sub")]
	public NexusGraphNodesAggregation[] Sub { get; set; }

	[JsonPropertyName("value")]
	public int Value { get; set; }
}