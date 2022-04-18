﻿using System;
using System.Runtime.InteropServices;
using System.Text;
#if !NET6_0_OR_GREATER
using ComputeSharp.D2D1.NetStandard.System.Text;
#endif

namespace ComputeSharp.D2D1.Interop;

/// <summary>
/// A helper type used to read and validate effect registration blobs produced by
/// <see cref="D2D1InteropServices.GetPixelShaderEffectRegistrationBlob{T}(out Guid)"/>.
/// </summary>
public unsafe readonly struct D2D1EffectRegistrationData
{
    /// <summary>
    /// Creates a new <see cref="D2D1EffectRegistrationData"/> instance with the specified parameters.
    /// </summary>
    /// <param name="effectId">The effect id.</param>
    /// <param name="numberOfInputs">The number of inputs for the effect.</param>
    /// <param name="xml">The XML text that can be used to register the effect.</param>
    /// <param name="propertyBindings">The <see cref="D2D1PropertyBinding"/> values for the effect.</param>
    /// <param name="effectFactory">A pointer to the effect factory callback.</param>
    private D2D1EffectRegistrationData(
        Guid effectId,
        int numberOfInputs,
        string xml,
        D2D1PropertyBinding[] propertyBindings,
        nint effectFactory)
    {
        EffectId = effectId;
        NumberOfInputs = numberOfInputs;
        Xml = xml;
        PropertyBindings = propertyBindings;
        EffectFactory = (void*)effectFactory;
    }

    /// <summary>
    /// Gets the id to use to register the effect.
    /// </summary>
    public Guid EffectId { get; }

    /// <summary>
    /// Gets the number of inputs for the effect.
    /// </summary>
    public int NumberOfInputs { get; }

    /// <summary>
    /// Gets the XML text with the effect description, that can be used to register it.
    /// </summary>
    public string Xml { get; }

    /// <summary>
    /// Gets the sequence of <see cref="D2D1PropertyBinding"/> values for the effect.
    /// </summary>
    public ReadOnlyMemory<D2D1PropertyBinding> PropertyBindings { get; }

    /// <summary>
    /// Gets a callback to an effect factory (a <see langword="delegate* unmanaged[Stdcall]&lt;IUnknown**, byte*, uint, HRESULT&gt;"/>).
    /// </summary>
    public void* EffectFactory { get; }

    /// <summary>
    /// Tries to load a <see cref="D2D1EffectRegistrationData"/> instance from the input binary blob.
    /// </summary>
    /// <param name="blob">The input binary blob to deserialize.</param>
    /// <param name="data">The resulting <see cref="D2D1EffectRegistrationData"/> instance, if successful.</param>
    /// <returns>Whether or not the input blob has been correctly deserialized (if it was not malformed).</returns>
    /// <remarks>
    /// The input blob should have been created by a call to any of the overloads of
    /// <see cref="D2D1InteropServices.GetPixelShaderEffectRegistrationBlob{T}(out Guid)"/>.
    /// </remarks>
    public static unsafe bool TryLoad(ReadOnlyMemory<byte> blob, out D2D1EffectRegistrationData data)
    {
        data = default;

        if (blob.IsEmpty)
        {
            return false;
        }

        ReadOnlySpan<byte> span = blob.Span;

        // Effect id
        if (!MemoryMarshal.TryRead(span, out Guid effectId))
        {
            return false;
        }

        span = span.Slice(sizeof(Guid));

        // Number of inputs
        if (!MemoryMarshal.TryRead(span, out int numberOfInputs) ||
            numberOfInputs < 0)
        {
            return false;
        }

        span = span.Slice(sizeof(int));

        // Effect XML
        int lengthOfXml = span.IndexOf((byte)'\0');

        if (lengthOfXml == -1)
        {
            return false;
        }

        string xml = Encoding.UTF8.GetString(span.Slice(0, lengthOfXml));

        span = span.Slice(lengthOfXml + 1);

        // Number of bindings
        if (!MemoryMarshal.TryRead(span, out int numberOfBindings) ||
            numberOfBindings < 0)
        {
            return false;
        }

        span = span.Slice(sizeof(int));

        D2D1PropertyBinding[] propertyBindings = new D2D1PropertyBinding[numberOfBindings];

        // Property bindings
        for (int i = 0; i < numberOfBindings; i++)
        {
            // Property name
            int lengthOfName = span.IndexOf((byte)'\0');

            if (lengthOfName == -1)
            {
                return false;
            }

            string name = Encoding.UTF8.GetString(span.Slice(0, lengthOfName));

            span = span.Slice(lengthOfName + 1);

            // Property getter
            if (!MemoryMarshal.TryRead(span, out nint getter))
            {
                return false;
            }

            span = span.Slice(sizeof(nint));

            // Property setter
            if (!MemoryMarshal.TryRead(span, out nint setter))
            {
                return false;
            }

            span = span.Slice(sizeof(nint));

            propertyBindings[i] = new D2D1PropertyBinding(name, (void*)getter, (void*)setter);
        }

        // Effect factory
        if (!MemoryMarshal.TryRead(span, out nint effectFactory))
        {
            return false;
        }

        span = span.Slice(sizeof(nint));

        // If the buffer is bigger than expected, also consider it malformed
        if (span.Length > 0)
        {
            return false;
        }

        data = new D2D1EffectRegistrationData(
            effectId,
            numberOfInputs,
            xml,
            propertyBindings,
            effectFactory);

        return true;
    }
}
