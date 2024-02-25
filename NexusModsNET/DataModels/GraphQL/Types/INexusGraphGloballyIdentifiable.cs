using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public interface INexusGraphGloballyIdentifiable
	{
		[JsonProperty("globalId")]
		public string GlobalId { get; set; }

		[JsonProperty("id")]
		public string Id { get; set; }
	}
}