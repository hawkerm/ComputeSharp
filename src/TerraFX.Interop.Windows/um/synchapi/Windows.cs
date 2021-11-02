// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/synchapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("kernel32", ExactSpelling = true)]
        public static extern void InitializeSRWLock([NativeTypeName("PSRWLOCK")] SRWLOCK* SRWLock);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern void ReleaseSRWLockExclusive([NativeTypeName("PSRWLOCK")] SRWLOCK* SRWLock);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern void ReleaseSRWLockShared([NativeTypeName("PSRWLOCK")] SRWLOCK* SRWLock);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern void AcquireSRWLockExclusive([NativeTypeName("PSRWLOCK")] SRWLOCK* SRWLock);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern void AcquireSRWLockShared([NativeTypeName("PSRWLOCK")] SRWLOCK* SRWLock);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL ReleaseMutex(HANDLE hMutex);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WaitForSingleObject(HANDLE hHandle, [NativeTypeName("DWORD")] uint dwMilliseconds);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern HANDLE CreateMutexW([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpMutexAttributes, BOOL bInitialOwner, [NativeTypeName("LPCWSTR")] ushort* lpName);

        [NativeTypeName("#define CreateMutex CreateMutexW")]
        public static delegate*<SECURITY_ATTRIBUTES*, BOOL, ushort*, HANDLE> CreateMutex => &CreateMutexW;
    }
}
