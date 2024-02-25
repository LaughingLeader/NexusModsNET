﻿using Newtonsoft.Json;

using System;

namespace NexusModsNET.DataModels
{
	public class NexusModFileDownloadLink
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("short_name")]
		public string ShortName { get; set; }

		[JsonProperty("URI")]
		public Uri Uri { get; set; }
	}
}
