using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using System.Runtime.Serialization;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum NexusGraphRatingOptions
	{
		[EnumMember(Value = "positive")]
		Positive,
		[EnumMember(Value = "negative")]
		Negative,
		[EnumMember(Value = "abstained")]
		Abstained,
	}
}