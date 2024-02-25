using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphUpdateChangelogMutationPayload
	{
		[JsonProperty("changelogId")]
		public int ChangelogId { get; set; }

		[JsonProperty("success")]
		public bool Success { get; set; }
	}
}