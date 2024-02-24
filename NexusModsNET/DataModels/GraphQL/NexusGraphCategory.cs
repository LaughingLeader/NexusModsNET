using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL
{
	public class NexusGraphCategory
	{
		[JsonProperty("name")]
		public string Name { get; set; }
	}
}