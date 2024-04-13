namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphCreateChangelogMutationPayload
{
	[JsonPropertyName("changelogId")]
	public int ChangelogId { get; set; }

	[JsonPropertyName("success")]
	public bool Success { get; set; }
}