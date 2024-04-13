using System.Runtime.Serialization;namespace NexusModsNET.DataModels.GraphQL.Types;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum NexusGraphRatable
{
	[EnumMember(Value = "CollectionRevision")]
	CollectionRevision,
	[EnumMember(Value = "Mod")]
	Mod,
}