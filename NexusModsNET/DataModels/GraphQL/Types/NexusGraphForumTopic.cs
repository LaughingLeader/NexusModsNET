namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphForumTopic
{
	[JsonPropertyName("approved")]
	public bool Approved { get; set; }

	[JsonPropertyName("description")]
	public string Description { get; set; }

	[JsonPropertyName("forumId")]
	public int ForumId { get; set; }

	[JsonPropertyName("id")]
	public int Id { get; set; }

	[JsonPropertyName("pinned")]
	public bool Pinned { get; set; }

	[JsonPropertyName("posts")]
	public NexusGraphForumPost[] Posts { get; set; }

	[JsonPropertyName("postsCount")]
	public int PostsCount { get; set; }

	[JsonPropertyName("state")]
	public string State { get; set; }

	[JsonPropertyName("title")]
	public string Title { get; set; }

	[JsonPropertyName("titleSeo")]
	public string TitleSeo { get; set; }

	[JsonPropertyName("topicUrl")]
	public string TopicUrl { get; set; }

	[JsonPropertyName("views")]
	public int Views { get; set; }

	[JsonPropertyName("visible")]
	public string Visible { get; set; }
}