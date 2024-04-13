namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphUserMonthlySummary
{
	[JsonPropertyName("entries")]
	public NexusGraphUserMonthlySummaryEntry[] Entries { get; set; }

	[JsonPropertyName("user")]
	public NexusGraphUser User { get; set; }

	[JsonPropertyName("userId")]
	public int UserId { get; set; }
}