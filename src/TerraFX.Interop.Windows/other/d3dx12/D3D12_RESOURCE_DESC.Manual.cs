// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12.h in DirectX-Graphics-Samples commit a7a87f1853b5540f10920518021d91ae641033fb
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using static TerraFX.Interop.D3D12_RESOURCE_DIMENSION;
using static TerraFX.Interop.D3D12_RESOURCE_FLAGS;
using static TerraFX.Interop.D3D12_TEXTURE_LAYOUT;
using static TerraFX.Interop.DXGI_FORMAT;

namespace TerraFX.Interop
{
    internal unsafe partial struct D3D12_RESOURCE_DESC
    {
        public D3D12_RESOURCE_DESC(D3D12_RESOURCE_DIMENSION dimension, [NativeTypeName("UINT64")] ulong alignment, [NativeTypeName("UINT64")] ulong width, uint height, [NativeTypeName("UINT16")] ushort depthOrArraySize, [NativeTypeName("UINT16")] ushort mipLevels, DXGI_FORMAT format, uint sampleCount, uint sampleQuality, D3D12_TEXTURE_LAYOUT layout, D3D12_RESOURCE_FLAGS flags)
        {
            Dimension = dimension;
            Alignment = alignment;
            Width = width;
            Height = height;
            DepthOrArraySize = depthOrArraySize;
            MipLevels = mipLevels;
            Format = format;
            SampleDesc.Count = sampleCount;
            SampleDesc.Quality = sampleQuality;
            Layout = layout;
            Flags = flags;
        }

        public static D3D12_RESOURCE_DESC Buffer([NativeTypeName("const D3D12_RESOURCE_ALLOCATION_INFO &")] in D3D12_RESOURCE_ALLOCATION_INFO resAllocInfo, D3D12_RESOURCE_FLAGS flags = D3D12_RESOURCE_FLAG_NONE)
        {
            return new D3D12_RESOURCE_DESC(D3D12_RESOURCE_DIMENSION_BUFFER, resAllocInfo.Alignment, resAllocInfo.SizeInBytes, 1, 1, 1, DXGI_FORMAT_UNKNOWN, 1, 0, D3D12_TEXTURE_LAYOUT_ROW_MAJOR, flags);
        }

        public static D3D12_RESOURCE_DESC Buffer([NativeTypeName("UINT64")] ulong width, D3D12_RESOURCE_FLAGS flags = D3D12_RESOURCE_FLAG_NONE, [NativeTypeName("UINT64")] ulong alignment = 0)
        {
            return new D3D12_RESOURCE_DESC(D3D12_RESOURCE_DIMENSION_BUFFER, alignment, width, 1, 1, 1, DXGI_FORMAT_UNKNOWN, 1, 0, D3D12_TEXTURE_LAYOUT_ROW_MAJOR, flags);
        }

        public static D3D12_RESOURCE_DESC Tex1D(DXGI_FORMAT format, [NativeTypeName("UINT64")] ulong width, [NativeTypeName("UINT16")] ushort arraySize = 1, [NativeTypeName("UINT16")] ushort mipLevels = 0, D3D12_RESOURCE_FLAGS flags = D3D12_RESOURCE_FLAG_NONE, D3D12_TEXTURE_LAYOUT layout = D3D12_TEXTURE_LAYOUT_UNKNOWN, [NativeTypeName("UINT64")] ulong alignment = 0)
        {
            return new D3D12_RESOURCE_DESC(D3D12_RESOURCE_DIMENSION_TEXTURE1D, alignment, width, 1, arraySize, mipLevels, format, 1, 0, layout, flags);
        }

        public static D3D12_RESOURCE_DESC Tex2D(DXGI_FORMAT format, [NativeTypeName("UINT64")] ulong width, uint height, [NativeTypeName("UINT16")] ushort arraySize = 1, [NativeTypeName("UINT16")] ushort mipLevels = 0, uint sampleCount = 1, uint sampleQuality = 0, D3D12_RESOURCE_FLAGS flags = D3D12_RESOURCE_FLAG_NONE, D3D12_TEXTURE_LAYOUT layout = D3D12_TEXTURE_LAYOUT_UNKNOWN, [NativeTypeName("UINT64")] ulong alignment = 0)
        {
            return new D3D12_RESOURCE_DESC(D3D12_RESOURCE_DIMENSION_TEXTURE2D, alignment, width, height, arraySize, mipLevels, format, sampleCount, sampleQuality, layout, flags);
        }

        public static D3D12_RESOURCE_DESC Tex3D(DXGI_FORMAT format, [NativeTypeName("UINT64")] ulong width, uint height, [NativeTypeName("UINT16")] ushort depth, [NativeTypeName("UINT16")] ushort mipLevels = 0, D3D12_RESOURCE_FLAGS flags = D3D12_RESOURCE_FLAG_NONE, D3D12_TEXTURE_LAYOUT layout = D3D12_TEXTURE_LAYOUT_UNKNOWN, [NativeTypeName("UINT64")] ulong alignment = 0)
        {
            return new D3D12_RESOURCE_DESC(D3D12_RESOURCE_DIMENSION_TEXTURE3D, alignment, width, height, depth, mipLevels, format, 1, 0, layout, flags);
        }

        public ushort Depth
        {
            get
            {
                return (Dimension == D3D12_RESOURCE_DIMENSION_TEXTURE3D ? DepthOrArraySize : (ushort)1);
            }
        }

        public ushort ArraySize
        {
            get
            {
                return (Dimension != D3D12_RESOURCE_DIMENSION_TEXTURE3D ? DepthOrArraySize : (ushort)1);
            }
        }
    }
}
