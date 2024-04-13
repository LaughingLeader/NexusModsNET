namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphUpdateChangelogMutationPayload
{
	[JsonPropertyName("changelogId")]
	public int ChangelogId { get; set; }

	[JsonPropertyName("success")]
	public bool Success { get; set; }
}