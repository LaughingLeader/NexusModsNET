using System.Runtime.Serialization;namespace NexusModsNET.DataModels.GraphQL.Types;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum NexusGraphBugReportModerationStatus
{
	[EnumMember(Value = "none")]
	None,
	[EnumMember(Value = "hidden")]
	Hidden,
}