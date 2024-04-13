namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphCreateRatingMutationPayload
{
	[JsonPropertyName("averageRating")]
	public NexusGraphAverageRating AverageRating { get; set; }

	[JsonPropertyName("rating")]
	public NexusGraphRating Rating { get; set; }

	[JsonPropertyName("success")]
	public bool Success { get; set; }
}