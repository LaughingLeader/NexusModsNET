using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphActionLog
	{
		[JsonProperty("actionId")]
		public int ActionId { get; set; }

		[JsonProperty("date")]
		public int Date { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("gameId")]
		public int GameId { get; set; }

		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("ip")]
		public string Ip { get; set; }

		[JsonProperty("objectId")]
		public int ObjectId { get; set; }

		[JsonProperty("objectType")]
		public int ObjectType { get; set; }

		[JsonProperty("relatedId")]
		public int RelatedId { get; set; }

		[JsonProperty("relatedType")]
		public int RelatedType { get; set; }

		[JsonProperty("userId")]
		public int UserId { get; set; }
	}
}