using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using System.Runtime.Serialization;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum NexusGraphReorderLocation
	{
		[EnumMember(Value = "BEFORE")]
		Before,
		[EnumMember(Value = "AFTER")]
		After,
	}
}