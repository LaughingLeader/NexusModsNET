namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphClearCollectionBugReportModerationStatusMutationPayload
{
	[JsonPropertyName("collectionBugReport")]
	public NexusGraphCollectionBugReport CollectionBugReport { get; set; }
}