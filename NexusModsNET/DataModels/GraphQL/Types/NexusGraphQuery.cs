using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphQuery
	{
		[JsonProperty("categories")]
		public NexusGraphCategory[] Categories { get; set; }

		[JsonProperty("category")]
		public NexusGraphCategory? Category { get; set; }

		[JsonProperty("collection")]
		public NexusGraphCollection Collection { get; set; }

		[JsonProperty("collectionGames")]
		public NexusGraphGame[] CollectionGames { get; set; }

		[JsonProperty("collectionRevision")]
		public NexusGraphCollectionRevision CollectionRevision { get; set; }

		[JsonProperty("collectionRevisionUploadUrl")]
		public NexusGraphPresignedUrl CollectionRevisionUploadUrl { get; set; }

		[JsonProperty("collections")]
		public NexusGraphCollectionConnection Collections { get; set; }

		[JsonProperty("comment")]
		public NexusGraphComment Comment { get; set; }

		[JsonProperty("commentThread")]
		public NexusGraphCommentThread CommentThread { get; set; }

		[JsonProperty("externalVideo")]
		public NexusGraphExternalVideo ExternalVideo { get; set; }

		[JsonProperty("fileHash")]
		public NexusGraphFileHash[] FileHash { get; set; }

		[JsonProperty("fileHashes")]
		public NexusGraphFileHash[] FileHashes { get; set; }

		[JsonProperty("game")]
		public NexusGraphGame? Game { get; set; }

		[JsonProperty("games")]
		public NexusGraphGame[] Games { get; set; }

		[JsonProperty("legacyMods")]
		public NexusGraphModPage LegacyMods { get; set; }

		[JsonProperty("legacyModsByDomain")]
		public NexusGraphModPage LegacyModsByDomain { get; set; }

		[JsonProperty("modActions")]
		public NexusGraphActionLogConnection ModActions { get; set; }

		[JsonProperty("modEndorsers")]
		public NexusGraphModEndorserConnection ModEndorsers { get; set; }

		[JsonProperty("modFilesByUid")]
		public NexusGraphModFilePage ModFilesByUid { get; set; }

		[JsonProperty("moderationReason")]
		public NexusGraphModerationReason? ModerationReason { get; set; }

		[JsonProperty("moderationReasons")]
		public NexusGraphModerationReason[] ModerationReasons { get; set; }

		[JsonProperty("mods")]
		public NexusGraphModConnection Mods { get; set; }

		[JsonProperty("modsByUid")]
		public NexusGraphModPage ModsByUid { get; set; }

		[JsonProperty("myCollections")]
		public NexusGraphCollectionPage MyCollections { get; set; }

		[JsonProperty("optedInMods")]
		public NexusGraphOptedInMods OptedInMods { get; set; }

		[JsonProperty("paypalEmailLastChanged")]
		public NexusGraphActionLogConnection PaypalEmailLastChanged { get; set; }

		[JsonProperty("privateMessageUrl")]
		public string PrivateMessageUrl { get; set; }

		[JsonProperty("requestMediaUploadUrl")]
		public NexusGraphPresignedUrl RequestMediaUploadUrl { get; set; }

		[JsonProperty("searchComments")]
		public NexusGraphCommentSearchResultConnection SearchComments { get; set; }

		[JsonProperty("speedtestUrls")]
		public NexusGraphSpeedtestUrl[] SpeedtestUrls { get; set; }

		[JsonProperty("subscriptionActions")]
		public NexusGraphSubscriberActionsUnionConnection SubscriptionActions { get; set; }

		[JsonProperty("tag")]
		public NexusGraphTag? Tag { get; set; }

		[JsonProperty("tagCategories")]
		public NexusGraphTagCategory[] TagCategories { get; set; }

		[JsonProperty("tagCategory")]
		public NexusGraphTagCategory? TagCategory { get; set; }

		[JsonProperty("tags")]
		public NexusGraphTag[] Tags { get; set; }

		[JsonProperty("transactions")]
		public NexusGraphTransactionList Transactions { get; set; }

		[JsonProperty("unreadMessageCount")]
		public int UnreadMessageCount { get; set; }

		[JsonProperty("uploads")]
		public NexusGraphUploadList Uploads { get; set; }

		[JsonProperty("user")]
		public NexusGraphUser User { get; set; }

		[JsonProperty("userActions")]
		public NexusGraphActionLogConnection UserActions { get; set; }

		[JsonProperty("userByName")]
		public NexusGraphUser UserByName { get; set; }

		[JsonProperty("userMonthlyReport")]
		public NexusGraphUserMonthlyReport UserMonthlyReport { get; set; }

		[JsonProperty("userMonthlyReportById")]
		public NexusGraphUserMonthlyReport UserMonthlyReportById { get; set; }

		[JsonProperty("userMonthlySummary")]
		public NexusGraphUserMonthlySummary UserMonthlySummary { get; set; }
	}
}