using System;
using ComputeSharp.SwapChain.Shaders;

#if WINDOWS_UWP
using ComputeSharp.Uwp;
#else
using ComputeSharp.WinUI;
#endif

#nullable enable

namespace ComputeSharp.SwapChain.Core.Shaders.Runners;

/// <summary>
/// A specialized <see cref="IShaderRunner"/> for <see cref="ShoalOfFish"/>.
/// </summary>
public sealed class ShoalOfFishRunner : IShaderRunner
{
    private readonly Func<float3> mouseCoordinates;

    private ReadWriteBuffer<float4>? sharedBuffer;

    public ShoalOfFishRunner(Func<float3> mouseFactory)
    {
        this.mouseCoordinates = mouseFactory;
    }

    /// <inheritdoc/>
    public bool TryExecute(IReadWriteNormalizedTexture2D<float4> texture, TimeSpan timespan, object? parameter)
    {
        if (this.sharedBuffer is null)
        {
            this.sharedBuffer = texture.GraphicsDevice.AllocateReadWriteBuffer<float4>(ShoalOfFish.NUMFISH);

            texture.GraphicsDevice.For(ShoalOfFish.NUMFISH, new ShoalOfFishInitialization(new int2(texture.Width, texture.Height), this.sharedBuffer));
        }

        texture.GraphicsDevice.For(ShoalOfFish.NUMFISH, new ShoalOfFishLogic(this.mouseCoordinates(), new int2(texture.Width, texture.Height), this.sharedBuffer));
        texture.GraphicsDevice.ForEach(texture, new ShoalOfFishImage((float)timespan.TotalSeconds, this.sharedBuffer));

        return true;
    }
}
