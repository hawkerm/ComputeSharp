﻿// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    internal static unsafe partial class Windows
    {
        [NativeTypeName("#define INFINITE 0xFFFFFFFF")]
        public const uint INFINITE = 0xFFFFFFFF;
    }
}
