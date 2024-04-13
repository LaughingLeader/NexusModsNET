using System.Runtime.Serialization;namespace NexusModsNET.DataModels.GraphQL.Types;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum NexusGraphExternalVideoPlatform
{
	[EnumMember(Value = "youtube")]
	Youtube,
}