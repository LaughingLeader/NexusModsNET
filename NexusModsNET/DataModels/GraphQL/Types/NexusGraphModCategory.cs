using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphModCategory
	{
		[JsonProperty("date")]
		public int Date { get; set; }

		[JsonProperty("gameId")]
		public int GameId { get; set; }

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }
	}
}