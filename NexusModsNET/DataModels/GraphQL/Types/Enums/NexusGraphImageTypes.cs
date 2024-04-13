using System.Runtime.Serialization;namespace NexusModsNET.DataModels.GraphQL.Types;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum NexusGraphImageTypes
{
	[EnumMember(Value = "gallery")]
	Gallery,
	[EnumMember(Value = "tile")]
	Tile,
	[EnumMember(Value = "header")]
	Header,
}