﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using System;

namespace NexusModsNET.DataModels
{
	public class NexusModUpdate
	{
		[JsonProperty("mod_id")]
		public long ModId { get; set; }

		[JsonProperty("latest_file_update")]
		[JsonConverter(typeof(UnixDateTimeConverter))]
		public DateTimeOffset LatestFileUpdate { get; set; }

		[JsonProperty("latest_mod_activity")]
		[JsonConverter(typeof(UnixDateTimeConverter))]
		public DateTimeOffset LatestModActivity { get; set; }
	}
}
