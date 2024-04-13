﻿using System.Net;

namespace NexusModsNET.Exceptions;

/// <summary>
/// <inheritdoc/>
/// </summary>
[Serializable]
public class UnauthorizedException : NexusAPIException
{
	/// <summary>
	/// <inheritdoc/>
	/// </summary>
	public UnauthorizedException(HttpStatusCode statusCode) : base(statusCode) { }
	/// <summary>
	/// <inheritdoc/>
	/// </summary>
	public UnauthorizedException(string message, HttpStatusCode statusCode) : base(message, statusCode) { }
	/// <summary>
	/// <inheritdoc/>
	/// </summary>
	public UnauthorizedException(string message, HttpStatusCode statusCode, Exception inner) : base(message, statusCode, inner) { }
}
