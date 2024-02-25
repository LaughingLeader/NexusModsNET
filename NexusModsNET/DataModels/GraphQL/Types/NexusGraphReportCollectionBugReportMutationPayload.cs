using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphReportCollectionBugReportMutationPayload
	{
		[JsonProperty("success")]
		public bool Success { get; set; }
	}
}