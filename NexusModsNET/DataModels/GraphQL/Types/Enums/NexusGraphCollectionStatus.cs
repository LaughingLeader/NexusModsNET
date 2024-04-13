using System.Runtime.Serialization;namespace NexusModsNET.DataModels.GraphQL.Types;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum NexusGraphCollectionStatus
{
	[EnumMember(Value = "listed")]
	Listed,
	[EnumMember(Value = "unlisted")]
	Unlisted,
	[EnumMember(Value = "under_moderation")]
	UnderModeration,
	[EnumMember(Value = "discarded")]
	Discarded,
}