using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphCloseCollectionBugReportMutationPayload
	{
		[JsonProperty("collectionBugReport")]
		public NexusGraphCollectionBugReport CollectionBugReport { get; set; }
	}
}