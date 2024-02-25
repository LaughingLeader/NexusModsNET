using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphForumTopic
	{
		[JsonProperty("approved")]
		public bool Approved { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("forumId")]
		public int ForumId { get; set; }

		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("pinned")]
		public bool Pinned { get; set; }

		[JsonProperty("posts")]
		public NexusGraphForumPost[] Posts { get; set; }

		[JsonProperty("postsCount")]
		public int PostsCount { get; set; }

		[JsonProperty("state")]
		public string State { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }

		[JsonProperty("titleSeo")]
		public string TitleSeo { get; set; }

		[JsonProperty("topicUrl")]
		public string TopicUrl { get; set; }

		[JsonProperty("views")]
		public int Views { get; set; }

		[JsonProperty("visible")]
		public string Visible { get; set; }
	}
}