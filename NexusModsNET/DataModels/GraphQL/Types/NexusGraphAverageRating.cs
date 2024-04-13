namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphAverageRating
{
	[JsonPropertyName("average")]
	public float Average { get; set; }

	[JsonPropertyName("positive")]
	public int Positive { get; set; }

	[JsonPropertyName("total")]
	public int Total { get; set; }
}