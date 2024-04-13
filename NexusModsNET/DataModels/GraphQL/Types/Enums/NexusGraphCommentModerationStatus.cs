using System.Runtime.Serialization;namespace NexusModsNET.DataModels.GraphQL.Types;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum NexusGraphCommentModerationStatus
{
	[EnumMember(Value = "none")]
	None,
	[EnumMember(Value = "hidden")]
	Hidden,
	[EnumMember(Value = "locked")]
	Locked,
}