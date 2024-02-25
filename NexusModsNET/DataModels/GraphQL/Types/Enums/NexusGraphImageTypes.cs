using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using System.Runtime.Serialization;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum NexusGraphImageTypes
	{
		[EnumMember(Value = "gallery")]
		Gallery,
		[EnumMember(Value = "tile")]
		Tile,
		[EnumMember(Value = "header")]
		Header,
	}
}