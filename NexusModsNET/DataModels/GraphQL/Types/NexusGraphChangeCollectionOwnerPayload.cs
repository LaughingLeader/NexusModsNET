using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphChangeCollectionOwnerPayload
	{
		[JsonProperty("collection")]
		public NexusGraphCollection Collection { get; set; }

		[JsonProperty("success")]
		public bool Success { get; set; }
	}
}