using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphRemoveTagFromCollectionMutationPayload
	{
		[JsonProperty("success")]
		public bool Success { get; set; }
	}
}