using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using System.Runtime.Serialization;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum NexusGraphUpdatePolicy
	{
		[EnumMember(Value = "exact")]
		Exact,
		[EnumMember(Value = "latest")]
		Latest,
		[EnumMember(Value = "prefer")]
		Prefer,
	}
}