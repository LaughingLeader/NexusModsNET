using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphUserMonthlySummary
	{
		[JsonProperty("entries")]
		public NexusGraphUserMonthlySummaryEntry[] Entries { get; set; }

		[JsonProperty("user")]
		public NexusGraphUser User { get; set; }

		[JsonProperty("userId")]
		public int UserId { get; set; }
	}
}