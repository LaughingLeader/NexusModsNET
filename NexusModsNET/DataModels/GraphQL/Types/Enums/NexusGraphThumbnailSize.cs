using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using System.Runtime.Serialization;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum NexusGraphThumbnailSize
	{
		[EnumMember(Value = "small")]
		Small,
		[EnumMember(Value = "med")]
		Med,
		[EnumMember(Value = "large")]
		Large,
	}
}