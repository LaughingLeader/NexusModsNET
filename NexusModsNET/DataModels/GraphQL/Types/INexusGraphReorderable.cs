using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public interface INexusGraphReorderable
	{
		[JsonProperty("order")]
		public string Order { get; set; }
	}
}