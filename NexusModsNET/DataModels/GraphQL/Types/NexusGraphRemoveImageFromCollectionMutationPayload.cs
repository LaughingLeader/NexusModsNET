using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphRemoveImageFromCollectionMutationPayload
	{
		[JsonProperty("success")]
		public bool Success { get; set; }
	}
}