namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphHideCollectionBugReportMutationPayload
{
	[JsonPropertyName("collectionBugReport")]
	public NexusGraphCollectionBugReport CollectionBugReport { get; set; }
}