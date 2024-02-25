using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphRemoveTileImageFromCollectionMutationPayload
	{
		[JsonProperty("success")]
		public bool Success { get; set; }
	}
}