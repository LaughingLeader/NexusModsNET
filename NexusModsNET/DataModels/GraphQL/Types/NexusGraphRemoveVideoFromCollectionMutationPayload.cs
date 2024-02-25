using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphRemoveVideoFromCollectionMutationPayload
	{
		[JsonProperty("success")]
		public bool Success { get; set; }
	}
}