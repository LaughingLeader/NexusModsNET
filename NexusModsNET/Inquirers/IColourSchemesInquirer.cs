﻿using NexusModsNET.DataModels;

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace NexusModsNET.Inquirers
{
	/// <summary>
	/// Routes specific to retrieve information regarding colour-specific themes for games
	/// </summary>
	public interface IColourSchemesInquirer : IDisposable
	{
		/// <summary>
		/// Returns an <see cref="IEnumerable{T}"/> of all colour schemes, including the primary, secondary and 'darker' colours.
		/// </summary>
		/// <param name="cancellationToken">Enables cancellation of the Http request</param>
		Task<IEnumerable<NexusColourScheme>> GetColourSchemesAsync(CancellationToken cancellationToken = default);
	}
}