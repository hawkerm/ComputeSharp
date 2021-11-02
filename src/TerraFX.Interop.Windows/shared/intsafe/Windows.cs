// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/intsafe.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("#define UINT_MAX 0xffffffff")]
        public const uint UINT_MAX = 0xffffffff;

        [NativeTypeName("#define UINT32_MAX 0xffffffffui32")]
        public const uint UINT32_MAX = 0xffffffffU;

        [NativeTypeName("#define UINT64_MAX 0xffffffffffffffffui64")]
        public const ulong UINT64_MAX = 0xffffffffffffffffUL;
    }
}
