using System.Runtime.Serialization;namespace NexusModsNET.DataModels.GraphQL.Types;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum NexusGraphFilterLogicalOperator
{
	[EnumMember(Value = "AND")]
	And,
	[EnumMember(Value = "OR")]
	Or,
}