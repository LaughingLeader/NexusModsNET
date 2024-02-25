using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphUnlistCollectionMutationPayload
	{
		[JsonProperty("success")]
		public bool Success { get; set; }
	}
}