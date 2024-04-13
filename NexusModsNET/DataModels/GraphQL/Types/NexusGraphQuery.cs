namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphQuery
{
	[JsonPropertyName("categories")]
	public NexusGraphCategory[] Categories { get; set; }

	[JsonPropertyName("category")]
	public NexusGraphCategory? Category { get; set; }

	[JsonPropertyName("collection")]
	public NexusGraphCollection Collection { get; set; }

	[JsonPropertyName("collectionGames")]
	public NexusGraphGame[] CollectionGames { get; set; }

	[JsonPropertyName("collectionRevision")]
	public NexusGraphCollectionRevision CollectionRevision { get; set; }

	[JsonPropertyName("collectionRevisionUploadUrl")]
	public NexusGraphPresignedUrl CollectionRevisionUploadUrl { get; set; }

	[JsonPropertyName("collections")]
	public NexusGraphCollectionConnection Collections { get; set; }

	[JsonPropertyName("comment")]
	public NexusGraphComment Comment { get; set; }

	[JsonPropertyName("commentThread")]
	public NexusGraphCommentThread CommentThread { get; set; }

	[JsonPropertyName("externalVideo")]
	public NexusGraphExternalVideo ExternalVideo { get; set; }

	[JsonPropertyName("fileHash")]
	public NexusGraphFileHash[] FileHash { get; set; }

	[JsonPropertyName("fileHashes")]
	public NexusGraphFileHash[] FileHashes { get; set; }

	[JsonPropertyName("game")]
	public NexusGraphGame? Game { get; set; }

	[JsonPropertyName("games")]
	public NexusGraphGame[] Games { get; set; }

	[JsonPropertyName("legacyMods")]
	public NexusGraphModPage LegacyMods { get; set; }

	[JsonPropertyName("legacyModsByDomain")]
	public NexusGraphModPage LegacyModsByDomain { get; set; }

	[JsonPropertyName("modActions")]
	public NexusGraphActionLogConnection ModActions { get; set; }

	[JsonPropertyName("modEndorsers")]
	public NexusGraphModEndorserConnection ModEndorsers { get; set; }

	[JsonPropertyName("modFilesByUid")]
	public NexusGraphModFilePage ModFilesByUid { get; set; }

	[JsonPropertyName("moderationReason")]
	public NexusGraphModerationReason? ModerationReason { get; set; }

	[JsonPropertyName("moderationReasons")]
	public NexusGraphModerationReason[] ModerationReasons { get; set; }

	[JsonPropertyName("mods")]
	public NexusGraphModConnection Mods { get; set; }

	[JsonPropertyName("modsByUid")]
	public NexusGraphModPage ModsByUid { get; set; }

	[JsonPropertyName("myCollections")]
	public NexusGraphCollectionPage MyCollections { get; set; }

	[JsonPropertyName("optedInMods")]
	public NexusGraphOptedInMods OptedInMods { get; set; }

	[JsonPropertyName("paypalEmailLastChanged")]
	public NexusGraphActionLogConnection PaypalEmailLastChanged { get; set; }

	[JsonPropertyName("privateMessageUrl")]
	public string PrivateMessageUrl { get; set; }

	[JsonPropertyName("requestMediaUploadUrl")]
	public NexusGraphPresignedUrl RequestMediaUploadUrl { get; set; }

	[JsonPropertyName("searchComments")]
	public NexusGraphCommentSearchResultConnection SearchComments { get; set; }

	[JsonPropertyName("speedtestUrls")]
	public NexusGraphSpeedtestUrl[] SpeedtestUrls { get; set; }

	[JsonPropertyName("subscriptionActions")]
	public NexusGraphSubscriberActionsUnionConnection SubscriptionActions { get; set; }

	[JsonPropertyName("tag")]
	public NexusGraphTag? Tag { get; set; }

	[JsonPropertyName("tagCategories")]
	public NexusGraphTagCategory[] TagCategories { get; set; }

	[JsonPropertyName("tagCategory")]
	public NexusGraphTagCategory? TagCategory { get; set; }

	[JsonPropertyName("tags")]
	public NexusGraphTag[] Tags { get; set; }

	[JsonPropertyName("transactions")]
	public NexusGraphTransactionList Transactions { get; set; }

	[JsonPropertyName("unreadMessageCount")]
	public int UnreadMessageCount { get; set; }

	[JsonPropertyName("uploads")]
	public NexusGraphUploadList Uploads { get; set; }

	[JsonPropertyName("user")]
	public NexusGraphUser User { get; set; }

	[JsonPropertyName("userActions")]
	public NexusGraphActionLogConnection UserActions { get; set; }

	[JsonPropertyName("userByName")]
	public NexusGraphUser UserByName { get; set; }

	[JsonPropertyName("userMonthlyReport")]
	public NexusGraphUserMonthlyReport UserMonthlyReport { get; set; }

	[JsonPropertyName("userMonthlyReportById")]
	public NexusGraphUserMonthlyReport UserMonthlyReportById { get; set; }

	[JsonPropertyName("userMonthlySummary")]
	public NexusGraphUserMonthlySummary UserMonthlySummary { get; set; }
}