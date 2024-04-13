using System.Runtime.Serialization;namespace NexusModsNET.DataModels.GraphQL.Types;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum NexusGraphSortDirection
{
	[EnumMember(Value = "ASC")]
	Asc,
	[EnumMember(Value = "DESC")]
	Desc,
}