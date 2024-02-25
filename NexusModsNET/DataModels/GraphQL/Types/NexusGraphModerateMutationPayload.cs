using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphModerateMutationPayload
	{
		[JsonProperty("moderation")]
		public NexusGraphModeration Moderation { get; set; }

		[JsonProperty("success")]
		public bool Success { get; set; }
	}
}