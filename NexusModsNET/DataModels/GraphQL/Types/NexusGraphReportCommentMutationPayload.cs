namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphReportCommentMutationPayload
{
	[JsonPropertyName("report")]
	public NexusGraphCommentReport Report { get; set; }
}