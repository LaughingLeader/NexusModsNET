using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphUserMonthlySummaryEntry
	{
		[JsonProperty("modCount")]
		public int ModCount { get; set; }

		[JsonProperty("modValue")]
		public int ModValue { get; set; }

		[JsonProperty("month")]
		public int Month { get; set; }

		[JsonProperty("value")]
		public int Value { get; set; }

		[JsonProperty("year")]
		public int Year { get; set; }
	}
}