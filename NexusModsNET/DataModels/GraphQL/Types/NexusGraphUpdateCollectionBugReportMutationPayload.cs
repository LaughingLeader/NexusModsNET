using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphUpdateCollectionBugReportMutationPayload
	{
		[JsonProperty("collectionBugReport")]
		public NexusGraphCollectionBugReport CollectionBugReport { get; set; }
	}
}