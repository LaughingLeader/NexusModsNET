namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphSpeedtestUrl
{
	[JsonPropertyName("description")]
	public string Description { get; set; }

	[JsonPropertyName("location")]
	public string Location { get; set; }

	[JsonPropertyName("tag")]
	public string Tag { get; set; }

	[JsonPropertyName("title")]
	public string Title { get; set; }
}