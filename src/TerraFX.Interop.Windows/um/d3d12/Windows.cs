// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("d3d12", ExactSpelling = true)]
        public static extern HRESULT D3D12SerializeVersionedRootSignature([NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC *")] D3D12_VERSIONED_ROOT_SIGNATURE_DESC* pRootSignature, ID3DBlob** ppBlob, ID3DBlob** ppErrorBlob);

        [DllImport("d3d12", ExactSpelling = true)]
        public static extern HRESULT D3D12CreateDevice(IUnknown* pAdapter, D3D_FEATURE_LEVEL MinimumFeatureLevel, [NativeTypeName("const IID &")] Guid* riid, void** ppDevice);

        [DllImport("d3d12", ExactSpelling = true)]
        public static extern HRESULT D3D12GetDebugInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvDebug);

        [NativeTypeName("#define D3D12_DEFAULT_MSAA_RESOURCE_PLACEMENT_ALIGNMENT ( 4194304 )")]
        public const int D3D12_DEFAULT_MSAA_RESOURCE_PLACEMENT_ALIGNMENT = (4194304);

        [NativeTypeName("#define D3D12_DEFAULT_RESOURCE_PLACEMENT_ALIGNMENT ( 65536 )")]
        public const int D3D12_DEFAULT_RESOURCE_PLACEMENT_ALIGNMENT = (65536);

        [NativeTypeName("#define D3D12_SMALL_MSAA_RESOURCE_PLACEMENT_ALIGNMENT ( 65536 )")]
        public const int D3D12_SMALL_MSAA_RESOURCE_PLACEMENT_ALIGNMENT = (65536);

        [NativeTypeName("#define D3D12_SMALL_RESOURCE_PLACEMENT_ALIGNMENT ( 4096 )")]
        public const int D3D12_SMALL_RESOURCE_PLACEMENT_ALIGNMENT = (4096);

        [NativeTypeName("#define D3D12_COMMONSHADER_CONSTANT_BUFFER_PARTIAL_UPDATE_EXTENTS_BYTE_ALIGNMENT ( 16 )")]
        public const int D3D12_COMMONSHADER_CONSTANT_BUFFER_PARTIAL_UPDATE_EXTENTS_BYTE_ALIGNMENT = (16);

        [NativeTypeName("#define D3D12_FLOAT32_MAX ( 3.402823466e+38f )")]
        public const float D3D12_FLOAT32_MAX = (3.402823466e+38f);

        [NativeTypeName("#define D3D12_REQ_TEXTURE2D_U_OR_V_DIMENSION ( 16384 )")]
        public const int D3D12_REQ_TEXTURE2D_U_OR_V_DIMENSION = (16384);

        [NativeTypeName("#define D3D12_REQ_TEXTURE3D_U_V_OR_W_DIMENSION ( 2048 )")]
        public const int D3D12_REQ_TEXTURE3D_U_V_OR_W_DIMENSION = (2048);

        [NativeTypeName("#define D3D12_REQ_CONSTANT_BUFFER_ELEMENT_COUNT ( 4096 )")]
        public const int D3D12_REQ_CONSTANT_BUFFER_ELEMENT_COUNT = (4096);

        [NativeTypeName("#define D3D12_DESCRIPTOR_RANGE_OFFSET_APPEND ( 0xffffffff )")]
        public const uint D3D12_DESCRIPTOR_RANGE_OFFSET_APPEND = (0xffffffff);

        [NativeTypeName("#define D3D12_DEFAULT_SHADER_4_COMPONENT_MAPPING D3D12_ENCODE_SHADER_4_COMPONENT_MAPPING(0,1,2,3)")]
        public const int D3D12_DEFAULT_SHADER_4_COMPONENT_MAPPING = ((((0) & 0x7) | (((1) & 0x7) << 3) | (((2) & 0x7) << (3 * 2)) | (((3) & 0x7) << (3 * 3)) | (1 << (3 * 4))));

        [NativeTypeName("#define D3D12_RESOURCE_BARRIER_ALL_SUBRESOURCES ( 0xffffffff )")]
        public const uint D3D12_RESOURCE_BARRIER_ALL_SUBRESOURCES = (0xffffffff);
    }
}
