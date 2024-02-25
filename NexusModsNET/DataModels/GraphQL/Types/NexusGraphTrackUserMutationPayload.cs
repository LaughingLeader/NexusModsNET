using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphTrackUserMutationPayload
	{
		[JsonProperty("success")]
		public bool Success { get; set; }
	}
}