namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphForumPost
{
	[JsonPropertyName("authorId")]
	public int AuthorId { get; set; }

	[JsonPropertyName("authorName")]
	public string AuthorName { get; set; }

	[JsonPropertyName("id")]
	public int Id { get; set; }

	[JsonPropertyName("post")]
	public string Post { get; set; }

	[JsonPropertyName("postDate")]
	public int PostDate { get; set; }

	[JsonPropertyName("user")]
	public NexusGraphUser User { get; set; }
}