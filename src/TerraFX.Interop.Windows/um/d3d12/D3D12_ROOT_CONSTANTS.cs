// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    internal partial struct D3D12_ROOT_CONSTANTS
    {
        public uint ShaderRegister;

        public uint RegisterSpace;

        public uint Num32BitValues;
    }
}
