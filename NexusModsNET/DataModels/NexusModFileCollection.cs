namespace NexusModsNET.DataModels;

public class NexusModFileCollection
{
	[JsonPropertyName("files")]
	public NexusModFile[] ModFiles { get; set; }

	[JsonPropertyName("file_updates")]
	public NexusModFileUpdate[] ModFileUpdates { get; set; }
}
