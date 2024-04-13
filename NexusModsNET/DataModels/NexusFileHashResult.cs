namespace NexusModsNET.DataModels;

public class NexusFileHashResult
{
	[JsonPropertyName("mod")]
	public NexusMod Mod { get; set; }

	[JsonPropertyName("file_details")]
	public NexusModFile ModFile { get; set; }
}
