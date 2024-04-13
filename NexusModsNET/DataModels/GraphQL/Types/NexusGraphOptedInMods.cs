namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphOptedInMods
{
	[JsonPropertyName("count")]
	public int Count { get; set; }

	[JsonPropertyName("entries")]
	public NexusGraphOptedInMod[] Entries { get; set; }

	[JsonPropertyName("user")]
	public NexusGraphUser User { get; set; }

	[JsonPropertyName("userId")]
	public int UserId { get; set; }
}