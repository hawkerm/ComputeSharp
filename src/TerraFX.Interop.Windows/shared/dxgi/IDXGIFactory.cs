// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7B7166EC-21C7-44AE-B21A-C9AE321AE369")]
    [NativeTypeName("struct IDXGIFactory : IDXGIObject")]
    [NativeInheritance("IDXGIObject")]
    public unsafe partial struct IDXGIFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDXGIFactory*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDXGIFactory*, uint>)(lpVtbl[1]))((IDXGIFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDXGIFactory*, uint>)(lpVtbl[2]))((IDXGIFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<IDXGIFactory*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGIFactory*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
        {
            return ((delegate* unmanaged<IDXGIFactory*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGIFactory*)Unsafe.AsPointer(ref this), Name, pUnknown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<IDXGIFactory*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGIFactory*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent)
        {
            return ((delegate* unmanaged<IDXGIFactory*, Guid*, void**, int>)(lpVtbl[6]))((IDXGIFactory*)Unsafe.AsPointer(ref this), riid, ppParent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT EnumAdapters(uint Adapter, IDXGIAdapter** ppAdapter)
        {
            return ((delegate* unmanaged<IDXGIFactory*, uint, IDXGIAdapter**, int>)(lpVtbl[7]))((IDXGIFactory*)Unsafe.AsPointer(ref this), Adapter, ppAdapter);
        }
    }
}
