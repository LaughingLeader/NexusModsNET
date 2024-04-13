namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphModCategory
{
	[JsonPropertyName("date")]
	public int Date { get; set; }

	[JsonPropertyName("gameId")]
	public int GameId { get; set; }

	[JsonPropertyName("id")]
	public string Id { get; set; }

	[JsonPropertyName("name")]
	public string Name { get; set; }
}