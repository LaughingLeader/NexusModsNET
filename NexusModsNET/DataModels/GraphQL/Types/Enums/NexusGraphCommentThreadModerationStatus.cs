using System.Runtime.Serialization;namespace NexusModsNET.DataModels.GraphQL.Types;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum NexusGraphCommentThreadModerationStatus
{
	[EnumMember(Value = "none")]
	None,
	[EnumMember(Value = "locked")]
	Locked,
}