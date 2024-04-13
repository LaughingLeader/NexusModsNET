namespace NexusModsNET.DataModels.GraphQL.Query;

public class GraphArgument
{
	[JsonPropertyName("type")]
	public string Type { get; set; }

	[JsonPropertyName("optional")]
	public bool Optional { get; set; }

	public GraphArgument(string typeName, bool optional = false)
	{
		Type = typeName;
		Optional = optional;
	}
}
