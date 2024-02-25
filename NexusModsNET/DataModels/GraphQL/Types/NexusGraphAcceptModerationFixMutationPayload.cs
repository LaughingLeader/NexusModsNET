using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphAcceptModerationFixMutationPayload
	{
		[JsonProperty("moderationFix")]
		public NexusGraphModerationFix ModerationFix { get; set; }

		[JsonProperty("success")]
		public bool Success { get; set; }
	}
}