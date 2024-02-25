﻿using NexusModsNET.Inquirers;

using System;

namespace NexusModsNET
{
	/// <summary>
	/// Combines all other Inquirers for all available endpoints
	/// </summary>
	public interface IInfosInquirer : IDisposable
	{
		/// <summary>
		/// A manger to read or manage the limits of the API.
		/// </summary>
		IRateLimitsManagement RateLimitsManagement { get; }
		/// <summary>
		/// Routes specific to retrieve information regarding colour-specific themes for games
		/// </summary>
		IColourSchemesInquirer ColourSchemes { get; }
		/// <summary>
		/// Routes specific to retrieve information regarding supported games
		/// </summary>
		IGamesInquirer Games { get; }
		/// <summary>
		/// File specific routes (E.g. retrieving file information, retrieving download link)
		/// </summary>
		IModFilesInquirer ModFiles { get; }
		/// <summary>
		/// Mod specific routes (E.g. retrieving latest mods, endorsing a mod)
		/// </summary>
		IModsInquirer Mods { get; }
		/// <summary>
		/// Routes specific to the current user assigned to this API Key
		/// </summary>
		IUserInquirer User { get; }
		/// <summary>
		/// Routes specific to the v2 GraphQL API
		/// </summary>
		IGraphInquirer Graph { get; }
	}
}