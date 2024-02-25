using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphUserMonthlyReport
	{
		[JsonProperty("entries")]
		public NexusGraphUserMonthlyReportEntry[] Entries { get; set; }

		[JsonProperty("user")]
		public NexusGraphUser? User { get; set; }

		[JsonProperty("userId")]
		public int UserId { get; set; }
	}
}