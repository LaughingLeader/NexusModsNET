using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphClearCollectionBugReportModerationStatusMutationPayload
	{
		[JsonProperty("collectionBugReport")]
		public NexusGraphCollectionBugReport CollectionBugReport { get; set; }
	}
}