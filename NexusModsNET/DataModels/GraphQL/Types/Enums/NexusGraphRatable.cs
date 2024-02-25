using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using System.Runtime.Serialization;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum NexusGraphRatable
	{
		[EnumMember(Value = "CollectionRevision")]
		CollectionRevision,
		[EnumMember(Value = "Mod")]
		Mod,
	}
}