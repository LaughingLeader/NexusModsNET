namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphCreateCollectionBugReportCommentPayload
{
	[JsonPropertyName("collectionBugReportComment")]
	public NexusGraphComment CollectionBugReportComment { get; set; }
}