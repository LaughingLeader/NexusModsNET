using System;

namespace NexusModsNET.DataModels
{
	public class NexusApiLimits : INexusApiLimits
	{
		public int HourlyLimit { get; set; } = 100;
		public int HourlyRemaining { get; set; } = 100;
		public DateTime HourlyReset { get; set; }
		public int DailyLimit { get; set; } = 2500;
		public int DailyRemaining { get; set; } = 2500;
		public DateTime DailyReset { get; set; }
	}
}
