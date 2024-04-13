namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphUpdateCollectionBugReportMutationPayload
{
	[JsonPropertyName("collectionBugReport")]
	public NexusGraphCollectionBugReport CollectionBugReport { get; set; }
}