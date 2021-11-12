using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputeSharp.SwapChain.Shaders;

/// <summary>
/// A multi-pass shader creating a school of fish which will run away from the mouse.
/// Ported from <see href="https://www.shadertoy.com/view/ldd3DB"/>.
/// <para>Created by sebastien durand - 2016</para>
/// <para>License Creative Commons Attribution-NonCommercial-ShareAlike 3.0 Unported License.</para>
/// </summary>
internal static class ShoalOfFish
{
    public const int NUMFISH = 11;
    public const float MAX_ACC = 3.0f;
    public const float MAX_VEL = 0.5f;
    public const float RESIST = 0.2f;
}

/// <summary>
/// Simple compute used to initialize the shared buffer.
/// </summary>
[AutoConstructor]
internal readonly partial struct ShoalOfFishInitialization : IComputeShader
{
    /// <summary>
    /// Resolution of the texture to initialize positions of fish from.
    /// </summary>
    public readonly int2 resolution;

    /// <summary>
    /// Shared Buffer.
    /// </summary>
    public readonly ReadWriteBuffer<float4> buffer;

    /// <summary>
    /// Initializes the initial positions of the fish based on the resolution.
    /// </summary>
    /// <param name="res">Texture resolution.</param>
    /// <returns>Buffer with initial fish positions.</returns>
    public void Execute()
    {
        float2 res = new float2(resolution.X, resolution.Y) / resolution.Y;
        
        buffer[ThreadIds.X] = new float4(0.1f + 0.8f * ShoalOfFishLogic.Hash(ThreadIds.X) * res, 0, 0);
    }
}

/// <summary>
/// This class uses a shared buffer which effectively acts as an information store for fish locations.
/// It calculates the math each step to move each fish.
/// </summary>
[AutoConstructor]
internal readonly partial struct ShoalOfFishLogic : IComputeShader
{
    /// <summary>
    /// The current time since the start of the application.
    /// </summary>
    public readonly float time;

    /// <summary>
    /// Mouse coordinates, range 0-1 for X, Y.
    /// </summary>
    public readonly float2 mouse;

    /// <summary>
    /// Shared Buffer.
    /// </summary>
    public readonly ReadWriteBuffer<float4> fishes;

    /// <summary>
    /// Generate a hash from a vector.
    /// </summary>
    /// <param name="p">Vector to hash</param>
    /// <returns>Hashed vector</returns>
    internal static float2 Hash(float n) => Hlsl.Frac(Hlsl.Sin(new float2(n, n * 7.0f)) * 43758.5f);

    public void Execute()
    {
        float2 w, vel, acc, sumF, res = (float2)DispatchSize.XY / DispatchSize.Y;
        float d, a, v, dt = 0.03f;
        int id = ThreadIds.X;

        // = Animation step ===================================
        float4 fish = fishes[id];

        // - Sum Forces -----------------------------  
        // Borders action
        sumF = 0.8f * (1.0f / Hlsl.Abs(fish.XY) - 1.0f / Hlsl.Abs(res - fish.XY));

        // Mouse action        
        w = fish.XY - mouse.XY / DispatchSize.Y; // Repulsive force from mouse position
        sumF += Hlsl.Normalize(w) * 0.65f / Hlsl.Dot(w, w);

        // Calculate repulsion force with other fishs
        for (int i = 0; i < ShoalOfFish.NUMFISH; i++)
        {
            if (i != id)
            {                                            // only other fishs
                d = Hlsl.Length(w = fish.XY - fishes[i].XY);
                sumF -= d > 0.0f ? w * (6.3f + Hlsl.Log(d * d * 0.02f)) / Hlsl.Exp(d * d * 2.4f) / d  // attractive/repulsive force from otehrs
                    : 0.01f * Hash(id);                                   // if same pos : small ramdom force
            }
        }

        // Friction    
        sumF -= fish.ZW * ShoalOfFish.RESIST / dt;

        // - Dynamic calculation ---------------------     
        // Calculate acceleration A = (1/m * sumF) [cool m=1. here!]
        a = Hlsl.Length(acc = sumF);
        acc *= a > ShoalOfFish.MAX_ACC ? ShoalOfFish.MAX_ACC / a : 1.0f; // limit acceleration
                                                // Calculate speed
        v = Hlsl.Length(vel = fish.ZW + acc * dt);
        vel *= v > ShoalOfFish.MAX_VEL ? ShoalOfFish.MAX_VEL / v : 1.0f; // limit velocity
                                                   
        // - Save position and velocity of fish (xy = position, zw = velocity) 
        fishes[id] = new float4(fish.XY + vel * dt, vel);
    }
}

/// <summary>
/// This shader is responsible for drawing the final scene.
/// </summary>
[AutoConstructor]
internal readonly partial struct ShoalOfFishImage : IPixelShader<float4>
{
    /// <summary>
    /// The current time since the start of the application.
    /// </summary>
    public readonly float time;

    /// <summary>
    /// Shared Buffer.
    /// </summary>
    public readonly ReadWriteBuffer<float4> fishes;

    /// <summary>
    /// Draws the fish shape.
    /// </summary>
    /// <param name="i">Fish to retrieve.</param>
    /// <param name="p">Position to check.</param>
    /// <param name="a">acceleration?</param>
    /// <returns></returns>
    private float sdFish(int i, float2 p, float a)
    {
        float ds, c = Hlsl.Cos(a), s = Hlsl.Sin(a);
        p = Hlsl.Mul(p, 20.0f * new float2x2(c, s, -s, c)); // Rotate and rescale
        p.X = Hlsl.Mul(p.X, 0.97f + (0.04f + 0.2f * p.Y) * Hlsl.Cos(i + 9.0f * time));  // Swiming ondulation (+rotate in Z axes)
        ds = Hlsl.Min(Hlsl.Length(p - new float2(0.8f, 0f)) - 0.45f, Hlsl.Length(p - new float2(-0.14f, 0f)) - 0.12f);   // Distance to fish
        p.Y = Hlsl.Abs(p.Y) + 0.13f;

        return Hlsl.Max(Hlsl.Min(Hlsl.Length(p), Hlsl.Length(p - new float2(0.56f, 0f))) - 0.3f, -ds) * 0.05f;
    }

    public Float4 Execute()
    {
        float2 fragCoord = new(ThreadIds.X, DispatchSize.Y - ThreadIds.Y);

        float2 p = 1f / (float2)DispatchSize.XY;
        float d, m = 1e6F;
        float4 ct = default, fish;

        for (int i = 0; i < ShoalOfFish.NUMFISH; i++)
        {
            fish = fishes[i]; // (xy = position, zw = velocity) 
            m = Hlsl.Min(m, d = sdFish(i, fish.XY - fragCoord.XY * p.Y, Hlsl.Atan2(fish.W, fish.Z))); // Draw fish according to its direction
            // Background color sum based on fish velocity (blue => red) + Halo - simple version: c*smoothstep(.5,0.,d);
            ct += Hlsl.Lerp(
                new float4(0, 0, 1, 1), 
                new float4(1, 0, 0, 1), 
                Hlsl.Length(fish.ZW) / ShoalOfFish.MAX_VEL) * (2.0f / (1.0f + 3e3F * d * d * d) + 0.5f / (1.0f + 30.0f * d * d)
            );
        }

        // Mix fish color (white) and Halo
        return Hlsl.Lerp(1f, 0.5f * Hlsl.Sqrt(ct / ShoalOfFish.NUMFISH), Hlsl.SmoothStep(0.0f, p.Y * 1.2f, m));
    }
}
