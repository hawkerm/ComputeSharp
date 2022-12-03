namespace ComputeSharp.SwapChain.Shaders;

// The MIT License
// Copyright © 2020 Inigo Quilez
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions: The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software. THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

/// <summary>
/// This shader shows the signed distance to a disk using a circle, following the mouse cursor.
/// Ported from https://www.shadertoy.com/view/3ltSW2
/// <para>Created by Inigo Quilez</para>
/// <para>MIT License</para>
/// </summary>
[AutoConstructor]
#if SAMPLE_APP
[EmbeddedBytecode(DispatchAxis.XY)]
#endif
internal readonly partial struct DiskDistance : IPixelShader<float4>
{
    /// <summary>
    /// Mouse coordinates, range 0-1 for X, Y.
    /// </summary>
    private readonly float2 iMouse;

    // Colors to blend together
    private readonly float3 diskColor = new(1, 1, 1);
    private readonly float3 mouseColor = new(1, 1, 0);

    /// <summary>
    /// Function to calculate distance to circle.
    /// </summary>
    /// <param name="p"></param>
    /// <param name="r"></param>
    /// <returns></returns>
    private float DrawCircle(in float2 p, in float r)
    {
        return Hlsl.Length(p) - r;
    }

    public Float4 Execute()
    {
        float2 fragCoord = new(ThreadIds.X, ThreadIds.Y);

        // Center given coordinates in viewport
        float2 p = ((2.0f * fragCoord) - DispatchSize.XY) / DispatchSize.Y;

        // Mouse is given normalized, so we need to multiple by rendersize before translating back into our centralized axis
        float2 m = ((2.0f * this.iMouse.XY * DispatchSize.XY) - DispatchSize.XY) / DispatchSize.Y;

        // Circle at center point
        float d = DrawCircle(p, 0.5f);

        // coloring stripes White (1, 1, 1) in middle, effected by 2nd half outside circle
        float3 col = new float3(1, 1, 1) - (Hlsl.Sign(d) * new float3(0.1f, 0.4f, 0.7f));
        col *= 1.0f - Hlsl.Exp(-3.0f * Hlsl.Abs(d));
        col *= 0.8f + (0.2f * Hlsl.Cos(150.0f * d));
        col = Hlsl.Lerp(col, this.diskColor, 1.0f - Hlsl.SmoothStep(0.0f, 0.01f, Hlsl.Abs(d)));

        // Mouse circle from distance
        d = DrawCircle(m, 0.5f);

        // Larger circle centered at mouse cursor to the edge of the inner circle.
        col = Hlsl.Lerp(col, this.mouseColor, 1.0f - Hlsl.SmoothStep(0.0f, 0.005f, Hlsl.Abs(Hlsl.Length(p - m) - Hlsl.Abs(d)) - 0.0025f));

        // Small circle where mouse cursor is
        col = Hlsl.Lerp(col, this.mouseColor, 1.0f - Hlsl.SmoothStep(0.0f, 0.005f, Hlsl.Length(p - m) - 0.015f));

        return new float4(col, 1.0f);
    }
}