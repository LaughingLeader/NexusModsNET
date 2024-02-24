using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL
{
	public class NexusGraphChangelog
	{
		[JsonProperty("createdAt")]
		public string CreatedAt { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("id")]
		public long Id { get; set; }
	}
}