

using NexusModsNET.DataModels;

using System.Web;

namespace NexusModsNET.Internals;

internal static class InternalExtensions
{
	public readonly static JsonSerializerOptions DefaultJsonOpts = new() 
	{ 
		AllowTrailingCommas = true,
		DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
		WriteIndented = false
	};

	internal static Uri AddQuery(this Uri url, string paramName, string paramValue)
	{
		var uriBuilder = new UriBuilder(url);
		var query = HttpUtility.ParseQueryString(uriBuilder.Query);
		query[paramName] = paramValue;
		uriBuilder.Query = query.ToString();

		return uriBuilder.Uri;
	}

	internal static async Task<T> DeserializeContent<T>(this HttpContent httpContent)
	{
		using var content = await httpContent.ReadAsStreamAsync();
		return JsonSerializer.Deserialize<T>(content, DefaultJsonOpts);
	}

	internal static string GetTimePeriod(this NexusTimePeriod timePeriod)
	{
		switch (timePeriod)
		{
			case NexusTimePeriod.Day:
				return "1d";
			case NexusTimePeriod.Week:
				return "1w";
			default:
				return "1m";
		}
	}
}
