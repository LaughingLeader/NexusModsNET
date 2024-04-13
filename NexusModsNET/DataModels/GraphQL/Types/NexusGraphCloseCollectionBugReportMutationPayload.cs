namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphCloseCollectionBugReportMutationPayload
{
	[JsonPropertyName("collectionBugReport")]
	public NexusGraphCollectionBugReport CollectionBugReport { get; set; }
}