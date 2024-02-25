using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphCreateCollectionBugReportMutationPayload
	{
		[JsonProperty("collectionBugReport")]
		public NexusGraphCollectionBugReport CollectionBugReport { get; set; }
	}
}