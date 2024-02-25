using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphRemoveHeaderImageFromCollectionMutationPayload
	{
		[JsonProperty("success")]
		public bool Success { get; set; }
	}
}