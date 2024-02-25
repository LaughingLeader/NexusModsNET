using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphHideCollectionBugReportMutationPayload
	{
		[JsonProperty("collectionBugReport")]
		public NexusGraphCollectionBugReport CollectionBugReport { get; set; }
	}
}