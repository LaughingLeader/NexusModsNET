using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphForumPost
	{
		[JsonProperty("authorId")]
		public int AuthorId { get; set; }

		[JsonProperty("authorName")]
		public string AuthorName { get; set; }

		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("post")]
		public string Post { get; set; }

		[JsonProperty("postDate")]
		public int PostDate { get; set; }

		[JsonProperty("user")]
		public NexusGraphUser User { get; set; }
	}
}