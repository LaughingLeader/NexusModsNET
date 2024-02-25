using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public interface INexusGraphNode
	{
		[JsonProperty("id")]
		public string Id { get; set; }
	}
}