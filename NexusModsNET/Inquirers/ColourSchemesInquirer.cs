﻿using NexusModsNET.DataModels;
using NexusModsNET.Internals;

using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace NexusModsNET.Inquirers
{
	/// <summary>
	/// Routes specific to retrieve information regarding colour-specific themes for games
	/// </summary>
	public class ColourSchemesInquirer : InquirerBase, IColourSchemesInquirer
	{
		/// <summary>
		/// Routes specific to retrieve information regarding colour-specific themes for games
		/// </summary>
		/// <param name="client">The NexusMods client to use for this endpoint</param>
		public ColourSchemesInquirer(INexusModsClient client) : base(client) { }

		/// <summary>
		/// Returns an <see cref="IEnumerable{T}"/> of all colour schemes, including the primary, secondary and 'darker' colours.
		/// </summary>
		/// <param name="cancellationToken">Enables cancellation of the Http request</param>
		/// <returns></returns>
		public Task<IEnumerable<NexusColourScheme>> GetColourSchemesAsync(CancellationToken cancellationToken = default)
		{
			var requestUri = ConstructRequestUri(Routes.ColourSchemes.ColourSchemes);
			return Client.ProcessRequestAsync<IEnumerable<NexusColourScheme>>(requestUri, HttpMethod.Get, cancellationToken);
		}
	}
}
