using System.Runtime.Serialization;namespace NexusModsNET.DataModels.GraphQL.Types;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum NexusGraphThumbnailSize
{
	[EnumMember(Value = "small")]
	Small,
	[EnumMember(Value = "med")]
	Med,
	[EnumMember(Value = "large")]
	Large,
}