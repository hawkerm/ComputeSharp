﻿namespace ComputeSharp;

/// <summary>
/// An interface representing a typed readonly 3D texture containing normalized pixel data stored on GPU memory.
/// This interface can only be used to wrap <see cref="ReadOnlyTexture3D{T, TPixel}"/> instances.
/// </summary>
/// <typeparam name="TPixel">The type of normalized pixels used on the GPU side.</typeparam>
public interface IReadOnlyTexture3D<TPixel>
    where TPixel : unmanaged
{
    /// <summary>
    /// Gets the width of the current texture.
    /// </summary>
    int Width { get; }

    /// <summary>
    /// Gets the height of the current texture.
    /// </summary>
    int Height { get; }

    /// <summary>
    /// Gets the depth of the current texture.
    /// </summary>
    int Depth { get; }

    /// <summary>
    /// Gets a single <typeparamref name="TPixel"/> value from the current readonly texture.
    /// </summary>
    /// <param name="x">The horizontal offset of the value to get.</param>
    /// <param name="y">The vertical offset of the value to get.</param>
    /// <param name="z">The depthwise offset of the value to get.</param>
    /// <remarks>This API can only be used from a compute shader, and will always throw if used anywhere else.</remarks>
    TPixel this[int x, int y, int z] { get; }

    /// <summary>
    /// Gets a single <typeparamref name="TPixel"/> value from the current readonly texture.
    /// </summary>
    /// <param name="xyz">The coordinates of the value to get.</param>
    /// <remarks>This API can only be used from a compute shader, and will always throw if used anywhere else.</remarks>
    TPixel this[Int3 xyz] { get; }

    /// <summary>
    /// Gets a single <typeparamref name="TPixel"/> value from the current readonly texture with linear sampling.
    /// </summary>
    /// <param name="u">The horizontal normalized offset of the value to get.</param>
    /// <param name="v">The vertical normalized offset of the value to get.</param>
    /// <param name="w">The depthwise normalized offset of the value to get.</param>
    /// <remarks>This API can only be used from a compute shader, and will always throw if used anywhere else.</remarks>
    TPixel this[float u, float v, float w] { get; }

    /// <summary>
    /// Gets a single <typeparamref name="TPixel"/> value from the current readonly texture with linear sampling.
    /// </summary>
    /// <param name="uvw">The normalized coordinates of the value to get.</param>
    /// <remarks>This API can only be used from a compute shader, and will always throw if used anywhere else.</remarks>
    TPixel this[Float3 uvw] { get; }
}
