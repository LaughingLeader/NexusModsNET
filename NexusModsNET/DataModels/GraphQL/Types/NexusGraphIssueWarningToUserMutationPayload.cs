using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphIssueWarningToUserMutationPayload
	{
		[JsonProperty("success")]
		public bool Success { get; set; }
	}
}