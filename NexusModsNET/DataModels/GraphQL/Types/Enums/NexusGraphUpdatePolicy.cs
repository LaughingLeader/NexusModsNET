using System.Runtime.Serialization;namespace NexusModsNET.DataModels.GraphQL.Types;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum NexusGraphUpdatePolicy
{
	[EnumMember(Value = "exact")]
	Exact,
	[EnumMember(Value = "latest")]
	Latest,
	[EnumMember(Value = "prefer")]
	Prefer,
}