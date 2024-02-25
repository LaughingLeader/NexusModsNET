using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphReportCollectionMutationPayload
	{
		[JsonProperty("success")]
		public bool Success { get; set; }
	}
}