using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphWriteFullPageNotificationToUserMutationPayload
	{
		[JsonProperty("success")]
		public bool Success { get; set; }
	}
}