using System.Runtime.Serialization;namespace NexusModsNET.DataModels.GraphQL.Types;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum NexusGraphCommentReportStatus
{
	[EnumMember(Value = "open")]
	Open,
	[EnumMember(Value = "resolved")]
	Resolved,
}