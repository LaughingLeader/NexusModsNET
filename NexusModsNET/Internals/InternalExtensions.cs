﻿using Newtonsoft.Json;

using NexusModsNET.DataModels;

using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace NexusModsNET.Internals
{
	internal static class InternalExtensions
	{
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
			using (var content = await httpContent.ReadAsStreamAsync())
			using (var reader = new StreamReader(content))
			using (var jsonReader = new JsonTextReader(reader))
			{
				var jsonSerializer = new JsonSerializer();
				jsonSerializer.NullValueHandling = NullValueHandling.Ignore;
				return jsonSerializer.Deserialize<T>(jsonReader);
			}
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
}
