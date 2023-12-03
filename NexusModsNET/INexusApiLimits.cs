using System;

namespace NexusModsNET
{
	public interface INexusApiLimits
	{
		int HourlyLimit { get; set; }
		int HourlyRemaining { get; set; }
		DateTime HourlyReset { get; set; }
		int DailyLimit { get; set; }
		int DailyRemaining { get; set; }
		DateTime DailyReset { get; set; }
	}
}