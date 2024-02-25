using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using System.Runtime.Serialization;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum NexusGraphSortDirection
	{
		[EnumMember(Value = "ASC")]
		Asc,
		[EnumMember(Value = "DESC")]
		Desc,
	}
}