using System.Runtime.Serialization;namespace NexusModsNET.DataModels.GraphQL.Types;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum NexusGraphBugReportStatus
{
	[EnumMember(Value = "open")]
	Open,
	[EnumMember(Value = "closed")]
	Closed,
}