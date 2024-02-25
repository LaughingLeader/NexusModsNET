using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphReorderItemPayload
	{
		[JsonProperty("item")]
		public INexusGraphReorderable? Item { get; set; }
	}
}