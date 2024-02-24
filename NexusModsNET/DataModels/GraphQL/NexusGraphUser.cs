using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL
{
	public class NexusGraphUser
	{
		[JsonProperty("memberId")]
		public long MemberId { get; set; }

		[JsonProperty("avatar")]
		public string Avatar { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }
	}
}