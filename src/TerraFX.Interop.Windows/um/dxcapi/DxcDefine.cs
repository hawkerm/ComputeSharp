// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.

namespace TerraFX.Interop
{
    public unsafe partial struct DxcDefine
    {
        [NativeTypeName("LPCWSTR")]
        public ushort* Name;

        [NativeTypeName("LPCWSTR")]
        public ushort* Value;
    }
}
