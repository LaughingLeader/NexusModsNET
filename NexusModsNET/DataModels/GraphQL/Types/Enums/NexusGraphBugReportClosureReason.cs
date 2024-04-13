using System.Runtime.Serialization;namespace NexusModsNET.DataModels.GraphQL.Types;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum NexusGraphBugReportClosureReason
{
	[EnumMember(Value = "none")]
	None,
	[EnumMember(Value = "resolved")]
	Resolved,
	[EnumMember(Value = "not_a_bug")]
	NotABug,
	[EnumMember(Value = "wont_fix")]
	WontFix,
}