using System.Runtime.Serialization;namespace NexusModsNET.DataModels.GraphQL.Types;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum NexusGraphModSource
{
	[EnumMember(Value = "nexus")]
	Nexus,
	[EnumMember(Value = "direct")]
	Direct,
	[EnumMember(Value = "browse")]
	Browse,
	[EnumMember(Value = "manual")]
	Manual,
	[EnumMember(Value = "bundle")]
	Bundle,
}