using System;
using System.IO;
using ComputeSharp.SwapChain.Shaders;
using ComputeSharp.WinUI;
using Windows.ApplicationModel;

namespace ComputeSharp.SwapChain.WinUI.Shaders.Runners;

/// <summary>
/// A specialized <see cref="IShaderRunner"/> for <see cref="ShoalOfFish"/>.
/// </summary>
public sealed class ShoalOfFishRunner : IShaderRunner
{
    private Func<float2> mouseCoordinates;

    private ReadWriteBuffer<float4>? sharedBuffer;

    public ShoalOfFishRunner(Func<float2> mouseFactory)
    {
        mouseCoordinates = mouseFactory;
    }

    /// <inheritdoc/>
    public void Execute(IReadWriteTexture2D<Float4> texture, TimeSpan timespan)
    {
        if (sharedBuffer is null)
        {
            sharedBuffer = Gpu.Default.AllocateReadWriteBuffer<float4>(ShoalOfFish.NUMFISH);

            Gpu.Default.For(ShoalOfFish.NUMFISH, new ShoalOfFishInitialization(new int2(texture.Width, texture.Height), sharedBuffer));
        }
        
        Gpu.Default.For(ShoalOfFish.NUMFISH, new ShoalOfFishLogic((float)timespan.TotalSeconds, mouseCoordinates(), sharedBuffer));
        Gpu.Default.ForEach(texture, new ShoalOfFishImage((float)timespan.TotalSeconds, sharedBuffer));
    }
}
