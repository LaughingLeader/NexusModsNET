namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphActionLog
{
	[JsonPropertyName("actionId")]
	public int ActionId { get; set; }

	[JsonPropertyName("date")]
	public int Date { get; set; }

	[JsonPropertyName("description")]
	public string Description { get; set; }

	[JsonPropertyName("gameId")]
	public int GameId { get; set; }

	[JsonPropertyName("id")]
	public int Id { get; set; }

	[JsonPropertyName("ip")]
	public string Ip { get; set; }

	[JsonPropertyName("objectId")]
	public int ObjectId { get; set; }

	[JsonPropertyName("objectType")]
	public int ObjectType { get; set; }

	[JsonPropertyName("relatedId")]
	public int RelatedId { get; set; }

	[JsonPropertyName("relatedType")]
	public int RelatedType { get; set; }

	[JsonPropertyName("userId")]
	public int UserId { get; set; }
}