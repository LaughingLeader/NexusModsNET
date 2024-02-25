using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphGameVersion
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("reference")]
		public string Reference { get; set; }
	}
}