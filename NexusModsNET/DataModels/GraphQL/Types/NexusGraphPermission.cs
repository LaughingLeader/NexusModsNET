using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphPermission
	{
		[JsonProperty("global")]
		public bool Global { get; set; }

		[JsonProperty("key")]
		public string Key { get; set; }
	}
}