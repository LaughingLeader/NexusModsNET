using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using System.Runtime.Serialization;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum NexusGraphCollectionAggregate
	{
		[EnumMember(Value = "adult_content")]
		AdultContent,
		[EnumMember(Value = "categories")]
		Categories,
		[EnumMember(Value = "collection_ratings")]
		CollectionRatings,
		[EnumMember(Value = "collection_statuses")]
		CollectionStatuses,
		[EnumMember(Value = "games")]
		Games,
		[EnumMember(Value = "games_and_game_versions")]
		GamesAndGameVersions,
		[EnumMember(Value = "game_versions")]
		GameVersions,
		[EnumMember(Value = "has_draft_revision")]
		HasDraftRevision,
		[EnumMember(Value = "has_published_revision")]
		HasPublishedRevision,
		[EnumMember(Value = "tags")]
		Tags,
		[EnumMember(Value = "general_search")]
		GeneralSearch,
	}
}