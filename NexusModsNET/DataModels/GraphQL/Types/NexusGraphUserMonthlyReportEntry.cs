using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphUserMonthlyReportEntry
	{
		[JsonProperty("game")]
		public NexusGraphGame? Game { get; set; }

		[JsonProperty("gameId")]
		public int GameId { get; set; }

		[JsonProperty("mod")]
		public NexusGraphMod? Mod { get; set; }

		[JsonProperty("modCount")]
		public int ModCount { get; set; }

		[JsonProperty("modId")]
		public int ModId { get; set; }

		[JsonProperty("modValue")]
		public int ModValue { get; set; }

		[JsonProperty("month")]
		public int Month { get; set; }

		[JsonProperty("ratio")]
		public float Ratio { get; set; }

		[JsonProperty("reportId")]
		public int ReportId { get; set; }

		[JsonProperty("status")]
		public int Status { get; set; }

		[JsonProperty("value")]
		public int Value { get; set; }

		[JsonProperty("year")]
		public int Year { get; set; }
	}
}