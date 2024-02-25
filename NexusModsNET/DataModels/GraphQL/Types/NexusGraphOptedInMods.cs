using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphOptedInMods
	{
		[JsonProperty("count")]
		public int Count { get; set; }

		[JsonProperty("entries")]
		public NexusGraphOptedInMod[] Entries { get; set; }

		[JsonProperty("user")]
		public NexusGraphUser User { get; set; }

		[JsonProperty("userId")]
		public int UserId { get; set; }
	}
}