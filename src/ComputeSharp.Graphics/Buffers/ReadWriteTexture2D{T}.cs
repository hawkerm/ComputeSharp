﻿using System.Diagnostics;
using ComputeSharp.Exceptions;
using ComputeSharp.Graphics;
using ComputeSharp.Graphics.Buffers.Abstract;
using ComputeSharp.Graphics.Buffers.Enums;

namespace ComputeSharp
{
    /// <summary>
    /// A <see langword="class"/> representing a typed read write 2D texture stored on GPU memory.
    /// </summary>
    /// <typeparam name="T">The type of items stored on the texture.</typeparam>
    [DebuggerDisplay("{ToString(),raw}")]
    public sealed class ReadWriteTexture2D<T> : Texture2D<T>
        where T : unmanaged
    {
        /// <summary>
        /// Creates a new <see cref="ReadWriteTexture2D{T}"/> instance with the specified parameters.
        /// </summary>
        /// <param name="device">The <see cref="GraphicsDevice"/> associated with the current instance.</param>
        /// <param name="width">The width of the texture.</param>
        /// <param name="height">The height of the texture.</param>
        internal ReadWriteTexture2D(GraphicsDevice device, int width, int height)
            : base(device, width, height, TextureType.ReadWrite)
        {
        }

        /// <summary>
        /// Gets or sets a single <typeparamref name="T"/> value from the current readonly texture.
        /// </summary>
        /// <param name="xy">The coordinates of the value to get.</param>
        /// <remarks>This API can only be used from a compute shader, and will always throw if used anywhere else.</remarks>
        public ref T this[UInt2 xy] => throw new InvalidExecutionContextException($"{nameof(ReadOnlyTexture2D<T>)}<T>[UInt2]");

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"ComputeSharp.ReadWriteTexture2D<{typeof(T)}>[{Width}, {Height}]";
        }
    }
}
