using System;
using ComputeSharp.SwapChain.Shaders;
using ComputeSharp.WinUI;

namespace ComputeSharp.SwapChain.WinUI.Shaders.Runners;

/// <summary>
/// A specialized <see cref="IShaderRunner"/> for <see cref="ContouredLayers"/>.
/// </summary>
public sealed class ShoalOfFishRunner2 : IShaderRunner
{
    /// <summary>
    /// A texture for <c>\Textures\RustyMetal.png</c>.
    /// </summary>
    private ReadWriteTexture2D<float4>? texture;
    private int iFrame;

    private Func<float3> mouseCoordinates;

    public ShoalOfFishRunner2(Func<float3> mouseFactory)
    {
        mouseCoordinates = mouseFactory;
    }

    /// <inheritdoc/>
    public void Execute(IReadWriteTexture2D<Float4> texture, TimeSpan timespan)
    {
        if (this.texture is null)
        {
            this.texture = Gpu.Default.AllocateReadWriteTexture2D<float4>(texture.Width, texture.Height);
        }

        Gpu.Default.For(texture.Width, texture.Height, new BufferA(this.texture, iFrame++, mouseCoordinates()));
        Gpu.Default.ForEach(texture, new BufferB(this.texture, (float)timespan.TotalSeconds));
    }
}

[AutoConstructor]
public readonly partial struct BufferA : IComputeShader
{
    const float NB = 40.0f;
    const float MAX_ACC = 3.0f;
    const float MAX_VEL = 0.5f;
    const float RESIST = 0.2f;

    public readonly ReadWriteTexture2D<float4> iChannel0;
    public readonly int iFrame;
    public readonly float3 mouse;

    static float2 hash(float n) { return Hlsl.Frac(Hlsl.Sin(new float2(n, n * 7.0f)) * 43758.5f); }

    float4 Fish(int i)
    {
        // return texelFetch(iChannel0, ivec2(i, 0), 0);
        return iChannel0[i, 0];
    }

    public void Execute()
    {
        float2 uv = new(ThreadIds.X, ThreadIds.Y);

        if (uv.Y > 0.5f || uv.X > NB) return;

        float2 w, vel, acc, sumF, R = DispatchSize.XY, res = R / R.Y;
        float d, a, v, dt = 0.03f, id = Hlsl.Floor(uv.X);

        if (iFrame < 5)
        {
            iChannel0[ThreadIds.XY] = new float4(0.1f + 0.8f * hash(id) * res, 0, 0);
        }
        else
        {
            float4 fish = Fish((int)id);

            sumF = 0.8f * (1.0f / Hlsl.Abs(fish.XY) - 1.0f / Hlsl.Abs(res - fish.XY));
            w = fish.XY - new float2(mouse.X, 1 - mouse.Y) * DispatchSize.XY / DispatchSize.Y;
            sumF += Hlsl.Normalize(w) * 0.65f / Hlsl.Dot(w, w);

            for (float i = 0.0f; i < NB; i++)
            {
                if (i != id)
                {
                    d = Hlsl.Length(w = fish.XY - Fish((int)i).XY);
                    sumF -= d > 0.0f ? w * (6.3f + Hlsl.Log(d * d * 0.02f)) / Hlsl.Exp(d * d * 2.4f) / d : 0.01f * hash(id);
                }
            }

            sumF -= fish.ZW * RESIST / dt;
            a = Hlsl.Length(acc = sumF);
            acc *= a > MAX_ACC ? MAX_ACC / a : 1.0f;
            v = Hlsl.Length(vel = fish.ZW + acc * dt);
            vel *= v > MAX_VEL ? MAX_VEL / v : 1.0f;

            iChannel0[ThreadIds.XY] = new float4(fish.XY + vel * dt, vel);
        }
    }
}

[AutoConstructor]
public readonly partial struct BufferB : IPixelShader<float4>
{
    const float NB = 40.0f;
    const float MAX_ACC = 3.0f;
    const float MAX_VEL = 0.5f;
    const float RESIST = 0.2f;

    public readonly ReadWriteTexture2D<float4> iChannel0;
    public readonly float iTime;

    float sdFish(float i, float2 p, float a)
    {
        float ds, c = Hlsl.Cos(a), s = Hlsl.Sin(a);
        p = Hlsl.Mul(p, Hlsl.Mul(20.0f, new float2x2(c, s, -s, c)));
        p.X *= 0.97f + (0.04f + 0.2f * p.Y) * Hlsl.Cos(i + 9.0f * iTime);
        ds = Hlsl.Min(Hlsl.Length(p - new float2(0.8f, 0)) - 0.45f, Hlsl.Length(p - new float2(-0.14f, 0)) - 0.12f);
        p.Y = Hlsl.Abs(p.Y) + 0.13f;

        return Hlsl.Max(Hlsl.Min(Hlsl.Length(p), Hlsl.Length(p - new float2(0.56f, 0))) - 0.3f, -ds) * 0.05f;
    }


    public float4 Execute()
    {
        float2 uv = new(ThreadIds.X, DispatchSize.Y - ThreadIds.Y);
        float2 p = (float2)1.0f / DispatchSize.XY;

        float d, m = 1e6f;
        float4 c, ct = 0, fish;

        for (float i = 0.0f; i < NB; i++)
        {
            //fish = texelFetch(iChannel0, ivec2(i, 0), 0);
            fish = iChannel0[(int)i, 0];
            m = Hlsl.Min(m, d = sdFish(i, fish.XY - uv.XY * p.Y, Hlsl.Atan2(fish.W, fish.Z)));
            ct += Hlsl.Lerp(new float4(0, 0, 1, 1), new float4(1, 0, 0, 1), Hlsl.Length(fish.ZW) / MAX_VEL) * (2.0f / (1.0f + 3e3f * d * d * d) + 0.5f / (1.0f + 30.0f * d * d));
        }

        return Hlsl.Lerp(1.0f, 0.5f * Hlsl.Sqrt(ct / NB), Hlsl.SmoothStep(0.0f, p.Y * 1.2f, m));
    }
}