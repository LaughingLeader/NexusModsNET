namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphUserMonthlyReport
{
	[JsonPropertyName("entries")]
	public NexusGraphUserMonthlyReportEntry[] Entries { get; set; }

	[JsonPropertyName("user")]
	public NexusGraphUser? User { get; set; }

	[JsonPropertyName("userId")]
	public int UserId { get; set; }
}