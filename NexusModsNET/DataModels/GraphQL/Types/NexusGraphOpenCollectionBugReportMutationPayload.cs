namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphOpenCollectionBugReportMutationPayload
{
	[JsonPropertyName("collectionBugReport")]
	public NexusGraphCollectionBugReport CollectionBugReport { get; set; }
}