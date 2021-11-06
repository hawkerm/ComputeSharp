﻿#if !NET6_0_OR_GREATER

using System;

namespace ComputeSharp.Polyfills.System.IO;

/// <summary>
/// A polyfill type that mirrors some methods from <see cref="global::System.IO.Path"/> on .NET 5.
/// </summary>
internal static class Path
{
    /// <summary>
    /// Returns the extension of the given path.
    /// </summary>
    /// <remarks>
    /// The returned value is an empty <see cref="ReadOnlySpan{T}"/> if the given path does not include an extension.
    /// </remarks>
    public static ReadOnlySpan<char> GetExtension(ReadOnlySpan<char> path)
    {
        return global::System.IO.Path.GetExtension(path.ToString()).AsSpan();
    }
}

#endif
