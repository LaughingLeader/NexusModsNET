using System.Runtime.Serialization;namespace NexusModsNET.DataModels.GraphQL.Types;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum NexusGraphReorderLocation
{
	[EnumMember(Value = "BEFORE")]
	Before,
	[EnumMember(Value = "AFTER")]
	After,
}