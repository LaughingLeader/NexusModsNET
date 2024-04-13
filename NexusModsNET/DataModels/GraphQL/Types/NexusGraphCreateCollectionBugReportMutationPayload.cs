namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphCreateCollectionBugReportMutationPayload
{
	[JsonPropertyName("collectionBugReport")]
	public NexusGraphCollectionBugReport CollectionBugReport { get; set; }
}