using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphCreateCollectionBugReportCommentPayload
	{
		[JsonProperty("collectionBugReportComment")]
		public NexusGraphComment CollectionBugReportComment { get; set; }
	}
}