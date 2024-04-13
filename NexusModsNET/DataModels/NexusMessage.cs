namespace NexusModsNET.DataModels;

public class NexusMessage
{
	[JsonPropertyName("message")]
	public string Message { get; set; }
	[JsonPropertyName("status")]
	public string Status { get; set; }
}
