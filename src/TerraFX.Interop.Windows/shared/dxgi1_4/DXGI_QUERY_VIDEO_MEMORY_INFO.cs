// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_4.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct DXGI_QUERY_VIDEO_MEMORY_INFO
    {
        [NativeTypeName("UINT64")]
        public ulong Budget;

        [NativeTypeName("UINT64")]
        public ulong CurrentUsage;

        [NativeTypeName("UINT64")]
        public ulong AvailableForReservation;

        [NativeTypeName("UINT64")]
        public ulong CurrentReservation;
    }
}
