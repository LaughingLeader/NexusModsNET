using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL
{
	public class NexusGraphGame
	{
		[JsonProperty("id")]
		public long Id { get; set; }

		[JsonProperty("domainName")]
		public string DomainName { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }
	}
}