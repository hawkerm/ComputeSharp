// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("790A45F7-0D42-4876-983A-0A55CFE6F4AA")]
    [NativeTypeName("struct IDXGISwapChain1 : IDXGISwapChain")]
    [NativeInheritance("IDXGISwapChain")]
    public unsafe partial struct IDXGISwapChain1
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, void**, int>)(lpVtbl[0]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, uint>)(lpVtbl[1]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, uint>)(lpVtbl[2]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
        {
            return ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), Name, pUnknown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent)
        {
            return ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, void**, int>)(lpVtbl[6]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), riid, ppParent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppDevice)
        {
            return ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, void**, int>)(lpVtbl[7]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), riid, ppDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT Present(uint SyncInterval, uint Flags)
        {
            return ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, uint, uint, int>)(lpVtbl[8]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), SyncInterval, Flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetBuffer(uint Buffer, [NativeTypeName("const IID &")] Guid* riid, void** ppSurface)
        {
            return ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, uint, Guid*, void**, int>)(lpVtbl[9]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), Buffer, riid, ppSurface);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT ResizeBuffers(uint BufferCount, uint Width, uint Height, DXGI_FORMAT NewFormat, uint SwapChainFlags)
        {
            return ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, uint, uint, uint, DXGI_FORMAT, uint, int>)(lpVtbl[13]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), BufferCount, Width, Height, NewFormat, SwapChainFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT GetLastPresentCount(uint* pLastPresentCount)
        {
            return ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, uint*, int>)(lpVtbl[17]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pLastPresentCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT GetDesc1(DXGI_SWAP_CHAIN_DESC1* pDesc)
        {
            return ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, DXGI_SWAP_CHAIN_DESC1*, int>)(lpVtbl[18]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT GetCoreWindow([NativeTypeName("const IID &")] Guid* refiid, void** ppUnk)
        {
            return ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, void**, int>)(lpVtbl[21]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), refiid, ppUnk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public BOOL IsTemporaryMonoSupported()
        {
            return ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, int>)(lpVtbl[23]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this));
        }
    }
}
