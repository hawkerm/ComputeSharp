// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("#define E_OUTOFMEMORY _HRESULT_TYPEDEF_(0x8007000EL)")]
        public const int E_OUTOFMEMORY = unchecked((int)(0x8007000E));

        [NativeTypeName("#define E_INVALIDARG _HRESULT_TYPEDEF_(0x80070057L)")]
        public const int E_INVALIDARG = unchecked((int)(0x80070057));

        [NativeTypeName("#define E_NOINTERFACE _HRESULT_TYPEDEF_(0x80004002L)")]
        public const int E_NOINTERFACE = unchecked((int)(0x80004002));

        [NativeTypeName("#define E_POINTER _HRESULT_TYPEDEF_(0x80004003L)")]
        public const int E_POINTER = unchecked((int)(0x80004003));

        [NativeTypeName("#define E_HANDLE _HRESULT_TYPEDEF_(0x80070006L)")]
        public const int E_HANDLE = unchecked((int)(0x80070006));

        [NativeTypeName("#define E_ABORT _HRESULT_TYPEDEF_(0x80004004L)")]
        public const int E_ABORT = unchecked((int)(0x80004004));

        [NativeTypeName("#define E_FAIL _HRESULT_TYPEDEF_(0x80004005L)")]
        public const int E_FAIL = unchecked((int)(0x80004005));

        [NativeTypeName("#define E_ACCESSDENIED _HRESULT_TYPEDEF_(0x80070005L)")]
        public const int E_ACCESSDENIED = unchecked((int)(0x80070005));

        [NativeTypeName("#define S_OK ((HRESULT)0L)")]
        public const int S_OK = ((int)(0));

        [NativeTypeName("#define DXGI_ERROR_NOT_FOUND _HRESULT_TYPEDEF_(0x887A0002L)")]
        public const int DXGI_ERROR_NOT_FOUND = unchecked((int)(0x887A0002));
    }
}
