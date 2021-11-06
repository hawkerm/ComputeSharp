// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICImagingFactory1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x62, 0xF2, 0xCA, 0xCA,
                    0x70, 0x93,
                    0x15, 0x46,
                    0xA1,
                    0x3B,
                    0x9F,
                    0x55,
                    0x39,
                    0xDA,
                    0x4C,
                    0x0A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICImagingFactory2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE8, 0x06, 0x7D, 0x31,
                    0x24, 0x5F,
                    0x3D, 0x43,
                    0xBD,
                    0xF7,
                    0x79,
                    0xCE,
                    0x68,
                    0xD8,
                    0xAB,
                    0xC2
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_VendorMicrosoft
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCA, 0x49, 0xE7, 0xF0,
                    0xEF, 0xED,
                    0x89, 0x45,
                    0xA7,
                    0x3A,
                    0xEE,
                    0x0E,
                    0x62,
                    0x6A,
                    0x2A,
                    0x2B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_VendorMicrosoftBuiltIn
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFD, 0x30, 0x7A, 0x25,
                    0xB6, 0x06,
                    0x2B, 0x46,
                    0xAE,
                    0xA4,
                    0x63,
                    0xF7,
                    0x0B,
                    0x86,
                    0xE5,
                    0x33
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICPngDecoder1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7B, 0xA1, 0x9E, 0x38,
                    0x78, 0x50,
                    0xDE, 0x4C,
                    0xB6,
                    0xEF,
                    0x25,
                    0xC1,
                    0x51,
                    0x75,
                    0xC7,
                    0x51
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICPngDecoder2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x5B, 0x94, 0x18, 0xE0,
                    0x86, 0xAA,
                    0x08, 0x40,
                    0x9B,
                    0xD4,
                    0x67,
                    0x77,
                    0xA1,
                    0xE4,
                    0x0C,
                    0x11
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICBmpDecoder
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x62, 0x20, 0x46, 0x6B,
                    0xBF, 0x7C,
                    0x0D, 0x40,
                    0x9F,
                    0xDB,
                    0x81,
                    0x3D,
                    0xD1,
                    0x0F,
                    0x27,
                    0x78
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICIcoDecoder
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDF, 0xFC, 0x1B, 0xC6,
                    0x0F, 0x2E,
                    0xAD, 0x4A,
                    0xA8,
                    0xD7,
                    0xE0,
                    0x6B,
                    0xAF,
                    0xEB,
                    0xCD,
                    0xFE
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICJpegDecoder
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x80, 0xA4, 0x56, 0x94,
                    0x8B, 0xE8,
                    0xEA, 0x43,
                    0x9E,
                    0x73,
                    0x0B,
                    0x2D,
                    0x9B,
                    0x71,
                    0xB1,
                    0xCA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICGifDecoder
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3C, 0xDA, 0x1D, 0x38,
                    0xE9, 0x9C,
                    0x34, 0x48,
                    0xA2,
                    0x3E,
                    0x1F,
                    0x98,
                    0xF8,
                    0xFC,
                    0x52,
                    0xBE
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICTiffDecoder
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD9, 0x85, 0x4E, 0xB5,
                    0x23, 0xFE,
                    0x9F, 0x49,
                    0x8B,
                    0x88,
                    0x6A,
                    0xCE,
                    0xA7,
                    0x13,
                    0x75,
                    0x2B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICWmpDecoder
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x36, 0xEC, 0x6C, 0xA2,
                    0x4C, 0x23,
                    0x50, 0x49,
                    0xAE,
                    0x16,
                    0xE3,
                    0x4A,
                    0xAC,
                    0xE7,
                    0x1D,
                    0x0D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICDdsDecoder
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9F, 0x69, 0x53, 0x90,
                    0x41, 0xA3,
                    0x9D, 0x42,
                    0x9E,
                    0x90,
                    0xEE,
                    0x43,
                    0x7C,
                    0xF8,
                    0x0C,
                    0x73
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICBmpEncoder
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB4, 0x8B, 0xBE, 0x69,
                    0x6D, 0xD6,
                    0xC8, 0x47,
                    0x86,
                    0x5A,
                    0xED,
                    0x15,
                    0x89,
                    0x43,
                    0x37,
                    0x82
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICPngEncoder
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x69, 0x99, 0x94, 0x27,
                    0x6A, 0x87,
                    0xD7, 0x41,
                    0x94,
                    0x47,
                    0x56,
                    0x8F,
                    0x6A,
                    0x35,
                    0xA4,
                    0xDC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICJpegEncoder
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC1, 0xF5, 0x34, 0x1A,
                    0x5A, 0x4A,
                    0xDC, 0x46,
                    0xB6,
                    0x44,
                    0x1F,
                    0x45,
                    0x67,
                    0xE7,
                    0xA6,
                    0x76
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICGifEncoder
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x98, 0x55, 0x4F, 0x11,
                    0x22, 0x0B,
                    0xA0, 0x40,
                    0x86,
                    0xA1,
                    0xC8,
                    0x3E,
                    0xA4,
                    0x95,
                    0xAD,
                    0xBD
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICTiffEncoder
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x10, 0xBE, 0x31, 0x01,
                    0x01, 0x20,
                    0x5F, 0x4C,
                    0xA9,
                    0xB0,
                    0xCC,
                    0x88,
                    0xFA,
                    0xB6,
                    0x4C,
                    0xE8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICWmpEncoder
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCB, 0xE3, 0x4C, 0xAC,
                    0xC1, 0xE1,
                    0xCD, 0x44,
                    0x82,
                    0x15,
                    0x5A,
                    0x16,
                    0x65,
                    0x50,
                    0x9E,
                    0xC2
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICDdsEncoder
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x94, 0xDE, 0x1D, 0xA6,
                    0xCE, 0x66,
                    0xC1, 0x4A,
                    0x88,
                    0x1B,
                    0x71,
                    0x68,
                    0x05,
                    0x88,
                    0x89,
                    0x5E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICAdngDecoder
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x11, 0x94, 0x1D, 0x98,
                    0x9E, 0x90,
                    0xA7, 0x42,
                    0x8F,
                    0x5D,
                    0xA7,
                    0x47,
                    0xFF,
                    0x05,
                    0x2E,
                    0xDB
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICJpegQualcommPhoneEncoder
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x62, 0x5C, 0xED, 0x68,
                    0x34, 0xF5,
                    0x79, 0x49,
                    0xB2,
                    0xB3,
                    0x68,
                    0x6A,
                    0x12,
                    0xB2,
                    0xB3,
                    0x4C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICHeifDecoder
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0A, 0xA8, 0xA4, 0xE9,
                    0xFE, 0x44,
                    0xE4, 0x4D,
                    0x89,
                    0x71,
                    0x71,
                    0x50,
                    0xB1,
                    0x0A,
                    0x51,
                    0x99
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICHeifEncoder
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC1, 0xCE, 0xBE, 0x0D,
                    0xB3, 0x9E,
                    0x60, 0x48,
                    0x9C,
                    0x6F,
                    0xDD,
                    0xBE,
                    0x86,
                    0x63,
                    0x45,
                    0x75
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICWebpDecoder
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x86, 0xE8, 0x93, 0x76,
                    0xC9, 0x51,
                    0x70, 0x40,
                    0x84,
                    0x19,
                    0x9F,
                    0x70,
                    0x73,
                    0x8E,
                    0xC8,
                    0xFA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICRAWDecoder
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x02, 0x57, 0x94, 0x41,
                    0x02, 0x83,
                    0xA6, 0x44,
                    0x94,
                    0x45,
                    0xAC,
                    0x98,
                    0xE8,
                    0xAF,
                    0xA0,
                    0x86
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_ContainerFormatBmp
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7E, 0xD8, 0xF1, 0x0A,
                    0xFE, 0xFC,
                    0x88, 0x41,
                    0xBD,
                    0xEB,
                    0xA7,
                    0x90,
                    0x64,
                    0x71,
                    0xCB,
                    0xE3
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_ContainerFormatPng
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF4, 0xFA, 0x7C, 0x1B,
                    0x3F, 0x71,
                    0x3C, 0x47,
                    0xBB,
                    0xCD,
                    0x61,
                    0x37,
                    0x42,
                    0x5F,
                    0xAE,
                    0xAF
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_ContainerFormatIco
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC4, 0x60, 0xA8, 0xA3,
                    0x8F, 0x33,
                    0x17, 0x4C,
                    0x91,
                    0x9A,
                    0xFB,
                    0xA4,
                    0xB5,
                    0x62,
                    0x8F,
                    0x21
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_ContainerFormatJpeg
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAA, 0xA5, 0xE4, 0x19,
                    0x62, 0x56,
                    0xC5, 0x4F,
                    0xA0,
                    0xC0,
                    0x17,
                    0x58,
                    0x02,
                    0x8E,
                    0x10,
                    0x57
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_ContainerFormatTiff
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x30, 0xCC, 0x3B, 0x16,
                    0xE9, 0xE2,
                    0x0B, 0x4F,
                    0x96,
                    0x1D,
                    0xA3,
                    0xE9,
                    0xFD,
                    0xB7,
                    0x88,
                    0xA3
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_ContainerFormatGif
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x01, 0x56, 0x8A, 0x1F,
                    0x4D, 0x7D,
                    0xBD, 0x4C,
                    0x9C,
                    0x82,
                    0x1B,
                    0xC8,
                    0xD4,
                    0xEE,
                    0xB9,
                    0xA5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_ContainerFormatWmp
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAA, 0x7C, 0xA3, 0x57,
                    0x7A, 0x36,
                    0x40, 0x45,
                    0x91,
                    0x6B,
                    0xF1,
                    0x83,
                    0xC5,
                    0x09,
                    0x3A,
                    0x4B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_ContainerFormatDds
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x95, 0xCB, 0x67, 0x99,
                    0x85, 0x2E,
                    0xC8, 0x4A,
                    0x8C,
                    0xA2,
                    0x83,
                    0xD7,
                    0xCC,
                    0xD4,
                    0x25,
                    0xC9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_ContainerFormatAdng
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0D, 0x6D, 0xFF, 0xF3,
                    0xC0, 0x38,
                    0xC4, 0x41,
                    0xB1,
                    0xFE,
                    0x1F,
                    0x38,
                    0x24,
                    0xF1,
                    0x7B,
                    0x84
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_ContainerFormatHeif
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x21, 0x25, 0xE6, 0xE1,
                    0x87, 0x67,
                    0x5B, 0x40,
                    0xA3,
                    0x39,
                    0x50,
                    0x07,
                    0x15,
                    0xB5,
                    0x76,
                    0x3F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_ContainerFormatWebp
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE2, 0xB0, 0x94, 0xE0,
                    0xF2, 0x67,
                    0xB3, 0x45,
                    0xB0,
                    0xEA,
                    0x11,
                    0x53,
                    0x37,
                    0xCA,
                    0x7C,
                    0xF3
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_ContainerFormatRaw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x60, 0xCE, 0x99, 0xFE,
                    0x9C, 0xF1,
                    0x3C, 0x43,
                    0xA3,
                    0xAE,
                    0x00,
                    0xAC,
                    0xEF,
                    0xA9,
                    0xCA,
                    0x21
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICImagingCategories
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x80, 0xD3, 0xE3, 0xFA,
                    0xA4, 0xFE,
                    0x23, 0x46,
                    0x8C,
                    0x75,
                    0xC6,
                    0xB6,
                    0x11,
                    0x10,
                    0xB6,
                    0x81
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CATID_WICBitmapDecoders
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x37, 0x68, 0xD9, 0x7E,
                    0xF0, 0x96,
                    0x12, 0x48,
                    0xB2,
                    0x11,
                    0xF1,
                    0x3C,
                    0x24,
                    0x11,
                    0x7E,
                    0xD3
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CATID_WICBitmapEncoders
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x96, 0x72, 0x75, 0xAC,
                    0x22, 0x35,
                    0x11, 0x4E,
                    0x98,
                    0x62,
                    0xC1,
                    0x7B,
                    0xE5,
                    0xA1,
                    0x76,
                    0x7E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CATID_WICPixelFormats
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0F, 0xE7, 0x46, 0x2B,
                    0xA7, 0xCD,
                    0x3E, 0x47,
                    0x89,
                    0xF6,
                    0xDC,
                    0x96,
                    0x30,
                    0xA2,
                    0x39,
                    0x0B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CATID_WICFormatConverters
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE8, 0xEA, 0x35, 0x78,
                    0x14, 0xBF,
                    0xD1, 0x49,
                    0x93,
                    0xCE,
                    0x53,
                    0x3A,
                    0x40,
                    0x7B,
                    0x22,
                    0x48
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CATID_WICMetadataReader
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD8, 0x94, 0xAF, 0x05,
                    0x74, 0x71,
                    0xD2, 0x4C,
                    0xBE,
                    0x4A,
                    0x41,
                    0x24,
                    0xB8,
                    0x0E,
                    0xE4,
                    0xB8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CATID_WICMetadataWriter
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA4, 0xB9, 0xE3, 0xAB,
                    0x7D, 0x25,
                    0x97, 0x4B,
                    0xBD,
                    0x1A,
                    0x29,
                    0x4A,
                    0xF4,
                    0x96,
                    0x22,
                    0x2E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICDefaultFormatConverter
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDC, 0x11, 0x3F, 0x1A,
                    0x14, 0xB5,
                    0x17, 0x4B,
                    0x8C,
                    0x5F,
                    0x21,
                    0x54,
                    0x51,
                    0x38,
                    0x52,
                    0xF1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICFormatConverterHighColor
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x54, 0xD4, 0x75, 0xAC,
                    0x37, 0x9F,
                    0xF8, 0x48,
                    0xB9,
                    0x72,
                    0x4E,
                    0x19,
                    0xBC,
                    0x85,
                    0x60,
                    0x11
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICFormatConverterNChannel
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB2, 0xAB, 0x7C, 0xC1,
                    0xA3, 0xD4,
                    0xD7, 0x47,
                    0xA5,
                    0x57,
                    0x33,
                    0x9B,
                    0x2E,
                    0xFB,
                    0xD4,
                    0xF1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICFormatConverterWMPhoto
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2B, 0x17, 0xB5, 0x9C,
                    0x00, 0xD6,
                    0xBA, 0x46,
                    0xAB,
                    0x77,
                    0x77,
                    0xBB,
                    0x7E,
                    0x3A,
                    0x00,
                    0xD9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICPlanarFormatConverter
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB8, 0x32, 0x41, 0x18,
                    0xF8, 0x32,
                    0x84, 0x47,
                    0x91,
                    0x31,
                    0xDD,
                    0x72,
                    0x24,
                    0xB2,
                    0x34,
                    0x38
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormatDontCare
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat1bppIndexed
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x01
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat2bppIndexed
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x02
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat4bppIndexed
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x03
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat8bppIndexed
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x04
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormatBlackWhite
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x05
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat2bppGray
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x06
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat4bppGray
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x07
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat8bppGray
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x08
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat8bppAlpha
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x16, 0x01, 0xCD, 0xE6,
                    0xBA, 0xEE,
                    0x61, 0x41,
                    0xAA,
                    0x85,
                    0x27,
                    0xDD,
                    0x9F,
                    0xB3,
                    0xA8,
                    0x95
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat16bppBGR555
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x09
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat16bppBGR565
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x0A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat16bppBGRA5551
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2B, 0x7C, 0xEC, 0x05,
                    0xE6, 0xF1,
                    0x61, 0x49,
                    0xAD,
                    0x46,
                    0xE1,
                    0xCC,
                    0x81,
                    0x0A,
                    0x87,
                    0xD2
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat16bppGray
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x0B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat24bppBGR
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x0C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat24bppRGB
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x0D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat32bppBGR
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x0E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat32bppBGRA
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x0F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat32bppPBGRA
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x10
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat32bppGrayFloat
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x11
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat32bppRGB
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x95, 0x6B, 0x8C, 0xD9,
                    0xFE, 0x3E,
                    0xD6, 0x47,
                    0xBB,
                    0x25,
                    0xEB,
                    0x17,
                    0x48,
                    0xAB,
                    0x0C,
                    0xF1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat32bppRGBA
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2D, 0xAD, 0xC7, 0xF5,
                    0x8D, 0x6A,
                    0xDD, 0x43,
                    0xA7,
                    0xA8,
                    0xA2,
                    0x99,
                    0x35,
                    0x26,
                    0x1A,
                    0xE9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat32bppPRGBA
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x50, 0xA6, 0xC4, 0x3C,
                    0x27, 0xA5,
                    0x37, 0x4D,
                    0xA9,
                    0x16,
                    0x31,
                    0x42,
                    0xC7,
                    0xEB,
                    0xED,
                    0xBA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat48bppRGB
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x15
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat48bppBGR
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x84, 0xA3, 0x05, 0xE6,
                    0x68, 0xB4,
                    0xCE, 0x46,
                    0xBB,
                    0x2E,
                    0x36,
                    0xF1,
                    0x80,
                    0xE6,
                    0x43,
                    0x13
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat64bppRGB
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x11, 0x21, 0x18, 0xA1,
                    0x6D, 0x18,
                    0x42, 0x4D,
                    0xBC,
                    0x6A,
                    0x9C,
                    0x83,
                    0x03,
                    0xA8,
                    0xDF,
                    0xF9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat64bppRGBA
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x16
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat64bppBGRA
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7C, 0xFF, 0x62, 0x15,
                    0x52, 0xD3,
                    0xF9, 0x46,
                    0x97,
                    0x9E,
                    0x42,
                    0x97,
                    0x6B,
                    0x79,
                    0x22,
                    0x46
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat64bppPRGBA
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x17
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat64bppPBGRA
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8E, 0x8E, 0x51, 0x8C,
                    0xEC, 0xA4,
                    0x8B, 0x46,
                    0xAE,
                    0x70,
                    0xC9,
                    0xA3,
                    0x5A,
                    0x9C,
                    0x55,
                    0x30
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat16bppGrayFixedPoint
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x13
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat32bppBGR101010
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x14
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat48bppRGBFixedPoint
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x12
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat48bppBGRFixedPoint
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0E, 0x14, 0xCA, 0x49,
                    0xB6, 0xCA,
                    0x3B, 0x49,
                    0x9D,
                    0xDF,
                    0x60,
                    0x18,
                    0x7C,
                    0x37,
                    0x53,
                    0x2A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat96bppRGBFixedPoint
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x18
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat96bppRGBFloat
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8F, 0xD7, 0xFE, 0xE3,
                    0xDB, 0xE8,
                    0xCF, 0x4A,
                    0x84,
                    0xC1,
                    0xE9,
                    0x7F,
                    0x61,
                    0x36,
                    0xB3,
                    0x27
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat128bppRGBAFloat
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x19
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat128bppPRGBAFloat
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x1A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat128bppRGBFloat
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x1B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat32bppCMYK
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x1C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat64bppRGBAFixedPoint
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x1D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat64bppBGRAFixedPoint
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3C, 0xE3, 0x6D, 0x35,
                    0xD2, 0x54,
                    0x23, 0x4A,
                    0xBB,
                    0x04,
                    0x9B,
                    0x7B,
                    0xF9,
                    0xB1,
                    0xD4,
                    0x2D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat64bppRGBFixedPoint
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x40
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat128bppRGBAFixedPoint
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat128bppRGBFixedPoint
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x41
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat64bppRGBAHalf
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x3A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat64bppPRGBAHalf
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC2, 0x26, 0xAD, 0x58,
                    0x23, 0xC6,
                    0x9D, 0x4D,
                    0xB3,
                    0x20,
                    0x38,
                    0x7E,
                    0x49,
                    0xF8,
                    0xC4,
                    0x42
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat64bppRGBHalf
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x42
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat48bppRGBHalf
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x3B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat32bppRGBE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x3D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat16bppGrayHalf
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x3E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat32bppGrayFixedPoint
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x3F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat32bppRGBA1010102
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x72, 0x8D, 0x23, 0x25,
                    0xF9, 0xFC,
                    0x22, 0x45,
                    0xB5,
                    0x14,
                    0x55,
                    0x78,
                    0xE5,
                    0xAD,
                    0x55,
                    0xE0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat32bppRGBA1010102XR
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9A, 0x6B, 0xDE, 0x00,
                    0x01, 0xC1,
                    0x4B, 0x43,
                    0xB5,
                    0x02,
                    0xD0,
                    0x16,
                    0x5E,
                    0xE1,
                    0x12,
                    0x2C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat32bppR10G10B10A2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB5, 0x1B, 0x4E, 0x60,
                    0x3C, 0x8A,
                    0x65, 0x4B,
                    0xB1,
                    0x1C,
                    0xBC,
                    0x0B,
                    0x8D,
                    0xD7,
                    0x5B,
                    0x7F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat32bppR10G10B10A2HDR10
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x5D, 0x5C, 0x21, 0x9C,
                    0xCC, 0x1A,
                    0x0E, 0x4F,
                    0xA4,
                    0xBC,
                    0x70,
                    0xFB,
                    0x3A,
                    0xE8,
                    0xFD,
                    0x28
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat64bppCMYK
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x1F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat24bpp3Channels
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x20
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat32bpp4Channels
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x21
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat40bpp5Channels
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x22
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat48bpp6Channels
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x23
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat56bpp7Channels
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x24
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat64bpp8Channels
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x25
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat48bpp3Channels
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x26
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat64bpp4Channels
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x27
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat80bpp5Channels
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x28
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat96bpp6Channels
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x29
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat112bpp7Channels
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x2A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat128bpp8Channels
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x2B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat40bppCMYKAlpha
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x2C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat80bppCMYKAlpha
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x2D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat32bpp3ChannelsAlpha
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x2E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat40bpp4ChannelsAlpha
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x2F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat48bpp5ChannelsAlpha
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x30
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat56bpp6ChannelsAlpha
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x31
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat64bpp7ChannelsAlpha
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x32
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat72bpp8ChannelsAlpha
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x33
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat64bpp3ChannelsAlpha
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x34
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat80bpp4ChannelsAlpha
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x35
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat96bpp5ChannelsAlpha
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x36
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat112bpp6ChannelsAlpha
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x37
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat128bpp7ChannelsAlpha
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x38
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat144bpp8ChannelsAlpha
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC3, 0xDD, 0x6F,
                    0x03, 0x4E,
                    0xFE, 0x4B,
                    0xB1,
                    0x85,
                    0x3D,
                    0x77,
                    0x76,
                    0x8D,
                    0xC9,
                    0x39
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat8bppY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x54, 0xDB, 0xB4, 0x91,
                    0xF9, 0x2D,
                    0xF0, 0x42,
                    0xB4,
                    0x49,
                    0x29,
                    0x09,
                    0xBB,
                    0x3D,
                    0xF8,
                    0x8E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat8bppCb
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xF2, 0x39, 0x13,
                    0xFE, 0x6B,
                    0x3E, 0x4C,
                    0x93,
                    0x02,
                    0xE4,
                    0xF3,
                    0xA6,
                    0xD0,
                    0xCA,
                    0x2A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat8bppCr
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x53, 0x50, 0x14, 0xB8,
                    0x16, 0x21,
                    0xF0, 0x49,
                    0x88,
                    0x35,
                    0xED,
                    0x84,
                    0x4B,
                    0x20,
                    0x5C,
                    0x51
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat16bppCbCr
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x6E, 0xBA, 0x95, 0xFF,
                    0xE0, 0x11,
                    0x63, 0x42,
                    0xBB,
                    0x45,
                    0x01,
                    0x72,
                    0x1F,
                    0x34,
                    0x60,
                    0xA4
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat16bppYQuantizedDctCoefficients
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x33, 0xF4, 0x55, 0xA3,
                    0xE8, 0x48,
                    0x42, 0x4A,
                    0x84,
                    0xD8,
                    0xE2,
                    0xAA,
                    0x26,
                    0xCA,
                    0x80,
                    0xA4
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat16bppCbQuantizedDctCoefficients
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x61, 0xFF, 0xC4, 0xD2,
                    0xA5, 0x56,
                    0xC2, 0x49,
                    0x8B,
                    0x5C,
                    0x4C,
                    0x19,
                    0x25,
                    0x96,
                    0x48,
                    0x37
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_WICPixelFormat16bppCrQuantizedDctCoefficients
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF0, 0x54, 0xE3, 0x2F,
                    0x80, 0x16,
                    0xD8, 0x42,
                    0x92,
                    0x31,
                    0xE7,
                    0x3C,
                    0x05,
                    0x65,
                    0xBF,
                    0xC1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("#define WINCODEC_SDK_VERSION1 0x0236")]
        public const int WINCODEC_SDK_VERSION1 = 0x0236;

        [NativeTypeName("#define WINCODEC_SDK_VERSION2 0x0237")]
        public const int WINCODEC_SDK_VERSION2 = 0x0237;

        [NativeTypeName("#define WINCODEC_SDK_VERSION WINCODEC_SDK_VERSION2")]
        public const int WINCODEC_SDK_VERSION = 0x0237;

        [NativeTypeName("#define WIC_JPEG_MAX_COMPONENT_COUNT ( 4 )")]
        public const int WIC_JPEG_MAX_COMPONENT_COUNT = (4);

        [NativeTypeName("#define WIC_JPEG_MAX_TABLE_INDEX ( 3 )")]
        public const int WIC_JPEG_MAX_TABLE_INDEX = (3);

        [NativeTypeName("#define WIC_JPEG_SAMPLE_FACTORS_ONE ( 0x11 )")]
        public const int WIC_JPEG_SAMPLE_FACTORS_ONE = (0x11);

        [NativeTypeName("#define WIC_JPEG_SAMPLE_FACTORS_THREE_420 ( 0x111122 )")]
        public const int WIC_JPEG_SAMPLE_FACTORS_THREE_420 = (0x111122);

        [NativeTypeName("#define WIC_JPEG_SAMPLE_FACTORS_THREE_422 ( 0x111121 )")]
        public const int WIC_JPEG_SAMPLE_FACTORS_THREE_422 = (0x111121);

        [NativeTypeName("#define WIC_JPEG_SAMPLE_FACTORS_THREE_440 ( 0x111112 )")]
        public const int WIC_JPEG_SAMPLE_FACTORS_THREE_440 = (0x111112);

        [NativeTypeName("#define WIC_JPEG_SAMPLE_FACTORS_THREE_444 ( 0x111111 )")]
        public const int WIC_JPEG_SAMPLE_FACTORS_THREE_444 = (0x111111);

        [NativeTypeName("#define WIC_JPEG_QUANTIZATION_BASELINE_ONE ( 0 )")]
        public const int WIC_JPEG_QUANTIZATION_BASELINE_ONE = (0);

        [NativeTypeName("#define WIC_JPEG_QUANTIZATION_BASELINE_THREE ( 0x10100 )")]
        public const int WIC_JPEG_QUANTIZATION_BASELINE_THREE = (0x10100);

        [NativeTypeName("#define WIC_JPEG_HUFFMAN_BASELINE_ONE ( 0 )")]
        public const int WIC_JPEG_HUFFMAN_BASELINE_ONE = (0);

        [NativeTypeName("#define WIC_JPEG_HUFFMAN_BASELINE_THREE ( 0x111100 )")]
        public const int WIC_JPEG_HUFFMAN_BASELINE_THREE = (0x111100);

        [NativeTypeName("#define GUID_WICPixelFormatUndefined GUID_WICPixelFormatDontCare")]
        public static ref readonly Guid GUID_WICPixelFormatUndefined => ref GUID_WICPixelFormatDontCare;

        [NativeTypeName("#define FACILITY_WINCODEC_ERR 0x898")]
        public const int FACILITY_WINCODEC_ERR = 0x898;

        [NativeTypeName("#define WINCODEC_ERR_BASE 0x2000")]
        public const int WINCODEC_ERR_BASE = 0x2000;

        [NativeTypeName("#define WINCODEC_ERR_GENERIC_ERROR E_FAIL")]
        public const int WINCODEC_ERR_GENERIC_ERROR = unchecked((int)(0x80004005));

        [NativeTypeName("#define WINCODEC_ERR_INVALIDPARAMETER E_INVALIDARG")]
        public const int WINCODEC_ERR_INVALIDPARAMETER = unchecked((int)(0x80070057));

        [NativeTypeName("#define WINCODEC_ERR_OUTOFMEMORY E_OUTOFMEMORY")]
        public const int WINCODEC_ERR_OUTOFMEMORY = unchecked((int)(0x8007000E));

        [NativeTypeName("#define WINCODEC_ERR_NOTIMPLEMENTED E_NOTIMPL")]
        public const int WINCODEC_ERR_NOTIMPLEMENTED = unchecked((int)(0x80004001));

        [NativeTypeName("#define WINCODEC_ERR_ABORTED E_ABORT")]
        public const int WINCODEC_ERR_ABORTED = unchecked((int)(0x80004004));

        [NativeTypeName("#define WINCODEC_ERR_ACCESSDENIED E_ACCESSDENIED")]
        public const int WINCODEC_ERR_ACCESSDENIED = unchecked((int)(0x80070005));

        [NativeTypeName("#define WINCODEC_ERR_VALUEOVERFLOW INTSAFE_E_ARITHMETIC_OVERFLOW")]
        public const int WINCODEC_ERR_VALUEOVERFLOW = unchecked((int)(0x80070216));

        [NativeTypeName("#define WICRawChangeNotification_ExposureCompensation 0x00000001")]
        public const int WICRawChangeNotification_ExposureCompensation = 0x00000001;

        [NativeTypeName("#define WICRawChangeNotification_NamedWhitePoint 0x00000002")]
        public const int WICRawChangeNotification_NamedWhitePoint = 0x00000002;

        [NativeTypeName("#define WICRawChangeNotification_KelvinWhitePoint 0x00000004")]
        public const int WICRawChangeNotification_KelvinWhitePoint = 0x00000004;

        [NativeTypeName("#define WICRawChangeNotification_RGBWhitePoint 0x00000008")]
        public const int WICRawChangeNotification_RGBWhitePoint = 0x00000008;

        [NativeTypeName("#define WICRawChangeNotification_Contrast 0x00000010")]
        public const int WICRawChangeNotification_Contrast = 0x00000010;

        [NativeTypeName("#define WICRawChangeNotification_Gamma 0x00000020")]
        public const int WICRawChangeNotification_Gamma = 0x00000020;

        [NativeTypeName("#define WICRawChangeNotification_Sharpness 0x00000040")]
        public const int WICRawChangeNotification_Sharpness = 0x00000040;

        [NativeTypeName("#define WICRawChangeNotification_Saturation 0x00000080")]
        public const int WICRawChangeNotification_Saturation = 0x00000080;

        [NativeTypeName("#define WICRawChangeNotification_Tint 0x00000100")]
        public const int WICRawChangeNotification_Tint = 0x00000100;

        [NativeTypeName("#define WICRawChangeNotification_NoiseReduction 0x00000200")]
        public const int WICRawChangeNotification_NoiseReduction = 0x00000200;

        [NativeTypeName("#define WICRawChangeNotification_DestinationColorContext 0x00000400")]
        public const int WICRawChangeNotification_DestinationColorContext = 0x00000400;

        [NativeTypeName("#define WICRawChangeNotification_ToneCurve 0x00000800")]
        public const int WICRawChangeNotification_ToneCurve = 0x00000800;

        [NativeTypeName("#define WICRawChangeNotification_Rotation 0x00001000")]
        public const int WICRawChangeNotification_Rotation = 0x00001000;

        [NativeTypeName("#define WICRawChangeNotification_RenderMode 0x00002000")]
        public const int WICRawChangeNotification_RenderMode = 0x00002000;

        public static ref readonly Guid IID_IWICPalette
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x40, 0x00, 0x00, 0x00,
                    0xF2, 0xA8,
                    0x77, 0x48,
                    0xBA,
                    0x0A,
                    0xFD,
                    0x2B,
                    0x66,
                    0x45,
                    0xFB,
                    0x94
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICBitmapSource
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x20, 0x01, 0x00, 0x00,
                    0xF2, 0xA8,
                    0x77, 0x48,
                    0xBA,
                    0x0A,
                    0xFD,
                    0x2B,
                    0x66,
                    0x45,
                    0xFB,
                    0x94
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICFormatConverter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x01, 0x03, 0x00, 0x00,
                    0xF2, 0xA8,
                    0x77, 0x48,
                    0xBA,
                    0x0A,
                    0xFD,
                    0x2B,
                    0x66,
                    0x45,
                    0xFB,
                    0x94
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICPlanarFormatConverter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCB, 0xE9, 0xBE, 0xBE,
                    0xB0, 0x83,
                    0xCC, 0x4D,
                    0x81,
                    0x32,
                    0xB0,
                    0xAA,
                    0xA5,
                    0x5E,
                    0xAC,
                    0x96
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICBitmapScaler
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x02, 0x03, 0x00, 0x00,
                    0xF2, 0xA8,
                    0x77, 0x48,
                    0xBA,
                    0x0A,
                    0xFD,
                    0x2B,
                    0x66,
                    0x45,
                    0xFB,
                    0x94
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICBitmapClipper
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x03, 0xCF, 0xFB, 0xE4,
                    0x3D, 0x22,
                    0x81, 0x4E,
                    0x93,
                    0x33,
                    0xD6,
                    0x35,
                    0x55,
                    0x6D,
                    0xD1,
                    0xB5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICBitmapFlipRotator
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4F, 0x83, 0x09, 0x50,
                    0x6A, 0x2D,
                    0xCE, 0x41,
                    0x9E,
                    0x1B,
                    0x17,
                    0xC5,
                    0xAF,
                    0xF7,
                    0xA7,
                    0x82
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICBitmapLock
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x23, 0x01, 0x00, 0x00,
                    0xF2, 0xA8,
                    0x77, 0x48,
                    0xBA,
                    0x0A,
                    0xFD,
                    0x2B,
                    0x66,
                    0x45,
                    0xFB,
                    0x94
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICBitmap
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x21, 0x01, 0x00, 0x00,
                    0xF2, 0xA8,
                    0x77, 0x48,
                    0xBA,
                    0x0A,
                    0xFD,
                    0x2B,
                    0x66,
                    0x45,
                    0xFB,
                    0x94
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICColorContext
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x02, 0x3A, 0x61, 0x3C,
                    0xB2, 0x34,
                    0xEA, 0x44,
                    0x9A,
                    0x7C,
                    0x45,
                    0xAE,
                    0xA9,
                    0xC6,
                    0xFD,
                    0x6D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICColorTransform
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4F, 0x03, 0x6F, 0xB6,
                    0xE2, 0xD0,
                    0xAB, 0x40,
                    0xB4,
                    0x36,
                    0x6D,
                    0xE3,
                    0x9E,
                    0x32,
                    0x1A,
                    0x94
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICFastMetadataEncoder
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x09, 0x2C, 0x4E, 0xB8,
                    0xC9, 0x78,
                    0xC4, 0x4A,
                    0x8B,
                    0xD3,
                    0x52,
                    0x4A,
                    0xE1,
                    0x66,
                    0x3A,
                    0x2F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICStream
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x60, 0xF8, 0x5F, 0x13,
                    0xB7, 0x22,
                    0xDF, 0x4D,
                    0xB0,
                    0xF6,
                    0x21,
                    0x8F,
                    0x4F,
                    0x29,
                    0x9A,
                    0x43
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICEnumMetadataItem
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x6D, 0xB4, 0x2B, 0xDC,
                    0x07, 0x3F,
                    0x1E, 0x48,
                    0x86,
                    0x25,
                    0x22,
                    0x0C,
                    0x4A,
                    0xED,
                    0xBB,
                    0x33
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICMetadataQueryReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x68, 0x96, 0x98, 0x30,
                    0xC9, 0xE1,
                    0x97, 0x45,
                    0xB3,
                    0x95,
                    0x45,
                    0x8E,
                    0xED,
                    0xB8,
                    0x08,
                    0xDF
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICMetadataQueryWriter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1A, 0x79, 0x21, 0xA7,
                    0xEF, 0x0D,
                    0x06, 0x4D,
                    0xBD,
                    0x91,
                    0x21,
                    0x18,
                    0xBF,
                    0x1D,
                    0xB1,
                    0x0B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICBitmapEncoder
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x03, 0x01, 0x00, 0x00,
                    0xF2, 0xA8,
                    0x77, 0x48,
                    0xBA,
                    0x0A,
                    0xFD,
                    0x2B,
                    0x66,
                    0x45,
                    0xFB,
                    0x94
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICBitmapFrameEncode
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x05, 0x01, 0x00, 0x00,
                    0xF2, 0xA8,
                    0x77, 0x48,
                    0xBA,
                    0x0A,
                    0xFD,
                    0x2B,
                    0x66,
                    0x45,
                    0xFB,
                    0x94
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICPlanarBitmapFrameEncode
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB8, 0xB7, 0x28, 0xF9,
                    0x21, 0x22,
                    0xC1, 0x40,
                    0xB7,
                    0x2E,
                    0x7E,
                    0x82,
                    0xF1,
                    0x97,
                    0x4D,
                    0x1A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICImageEncoder
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF8, 0x5B, 0xC7, 0x04,
                    0xE1, 0x3C,
                    0x3B, 0x47,
                    0xAC,
                    0xC5,
                    0x3C,
                    0xC4,
                    0xF5,
                    0xE9,
                    0x49,
                    0x99
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICBitmapDecoder
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE7, 0xE9, 0xDD, 0x9E,
                    0xEE, 0x8D,
                    0xEA, 0x47,
                    0x99,
                    0xDF,
                    0xE6,
                    0xFA,
                    0xF2,
                    0xED,
                    0x44,
                    0xBF
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICBitmapSourceTransform
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1B, 0x81, 0x16, 0x3B,
                    0x43, 0x6A,
                    0xC9, 0x4E,
                    0xB7,
                    0x13,
                    0x3D,
                    0x5A,
                    0x0C,
                    0x13,
                    0xB9,
                    0x40
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICPlanarBitmapSourceTransform
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCE, 0x9C, 0xFF, 0x3A,
                    0x95, 0xBE,
                    0x03, 0x43,
                    0xB9,
                    0x27,
                    0xE7,
                    0xD1,
                    0x6F,
                    0xF4,
                    0xA6,
                    0x13
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICBitmapFrameDecode
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1B, 0x81, 0x16, 0x3B,
                    0x43, 0x6A,
                    0xC9, 0x4E,
                    0xA8,
                    0x13,
                    0x3D,
                    0x93,
                    0x0C,
                    0x13,
                    0xB9,
                    0x40
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICProgressiveLevelControl
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x6F, 0x29, 0xAC, 0xDA,
                    0xA5, 0x7A,
                    0xBF, 0x4D,
                    0x8D,
                    0x15,
                    0x22,
                    0x5C,
                    0x59,
                    0x76,
                    0xF8,
                    0x91
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICProgressCallback
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCD, 0xF9, 0x76, 0x47,
                    0x17, 0x95,
                    0xFA, 0x45,
                    0xBF,
                    0x24,
                    0xE8,
                    0x9C,
                    0x5E,
                    0xC5,
                    0xC6,
                    0x0C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICBitmapCodecProgressNotification
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4E, 0x02, 0xC1, 0x64,
                    0xCF, 0xC3,
                    0x62, 0x44,
                    0x80,
                    0x78,
                    0x88,
                    0xC2,
                    0xB1,
                    0x1C,
                    0x46,
                    0xD9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICComponentInfo
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0A, 0x3F, 0xBC, 0x23,
                    0x8B, 0x69,
                    0x57, 0x43,
                    0x88,
                    0x6B,
                    0xF2,
                    0x4D,
                    0x50,
                    0x67,
                    0x13,
                    0x34
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICFormatConverterInfo
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x65, 0xFB, 0x34, 0x9F,
                    0xF4, 0x13,
                    0x15, 0x4F,
                    0xBC,
                    0x57,
                    0x37,
                    0x26,
                    0xB5,
                    0xE5,
                    0x3D,
                    0x9F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICBitmapCodecInfo
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC4, 0x44, 0x7A, 0xE8,
                    0x6E, 0xB7,
                    0x47, 0x4C,
                    0x8B,
                    0x09,
                    0x29,
                    0x8E,
                    0xB1,
                    0x2A,
                    0x27,
                    0x14
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICBitmapEncoderInfo
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEE, 0xB4, 0xC9, 0x94,
                    0x9F, 0xA0,
                    0x92, 0x4F,
                    0x8A,
                    0x1E,
                    0x4A,
                    0x9B,
                    0xCE,
                    0x7E,
                    0x76,
                    0xFB
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICBitmapDecoderInfo
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7F, 0x00, 0xCD, 0xD8,
                    0x8F, 0xD0,
                    0x91, 0x41,
                    0x9B,
                    0xFC,
                    0x23,
                    0x6E,
                    0xA7,
                    0xF0,
                    0xE4,
                    0xB5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICPixelFormatInfo
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x01, 0xA6, 0xED, 0xE8,
                    0x48, 0x3D,
                    0x1A, 0x43,
                    0xAB,
                    0x44,
                    0x69,
                    0x05,
                    0x9B,
                    0xE8,
                    0x8B,
                    0xBE
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICPixelFormatInfo2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA2, 0x33, 0xDB, 0xA9,
                    0x5F, 0xAF,
                    0xC7, 0x43,
                    0xB6,
                    0x79,
                    0x74,
                    0xF5,
                    0x98,
                    0x4B,
                    0x5A,
                    0xA4
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICImagingFactory
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA9, 0xC8, 0x5E, 0xEC,
                    0x95, 0xC3,
                    0x14, 0x43,
                    0x9C,
                    0x77,
                    0x54,
                    0xD7,
                    0xA9,
                    0x35,
                    0xFF,
                    0x70
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICImagingFactory2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x45, 0x6B, 0x81, 0x7B,
                    0x96, 0x19,
                    0x76, 0x44,
                    0xB1,
                    0x32,
                    0xDE,
                    0x9E,
                    0x24,
                    0x7C,
                    0x8A,
                    0xF0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICDevelopRawNotificationCallback
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x6E, 0x5A, 0xC7, 0x95,
                    0x8C, 0x3E,
                    0xC2, 0x4E,
                    0x85,
                    0xA8,
                    0xAE,
                    0xBC,
                    0xC5,
                    0x51,
                    0xE5,
                    0x9B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICDevelopRaw
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x44, 0x5E, 0xEC, 0xFB,
                    0xBE, 0xF7,
                    0x65, 0x4B,
                    0xB7,
                    0xF8,
                    0xC0,
                    0xC8,
                    0x1F,
                    0xEF,
                    0x02,
                    0x6D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICDdsDecoder
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x37, 0xD5, 0x9C, 0x40,
                    0x32, 0x85,
                    0xCB, 0x40,
                    0x97,
                    0x74,
                    0xE2,
                    0xFE,
                    0xB2,
                    0xDF,
                    0x4E,
                    0x9C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICDdsEncoder
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4C, 0xDB, 0xAC, 0x5C,
                    0x7E, 0x40,
                    0xB3, 0x41,
                    0xB9,
                    0x36,
                    0xD0,
                    0xF0,
                    0x10,
                    0xCD,
                    0x67,
                    0x32
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICDdsFrameDecode
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x61, 0x0C, 0x4C, 0x3D,
                    0xA4, 0x18,
                    0xE4, 0x41,
                    0xBD,
                    0x80,
                    0x48,
                    0x1A,
                    0x4F,
                    0xC9,
                    0xF4,
                    0x64
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICJpegFrameDecode
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x6E, 0xF6, 0x39, 0x89,
                    0x6A, 0xC4,
                    0x21, 0x4C,
                    0xA9,
                    0xD1,
                    0x98,
                    0xB3,
                    0x27,
                    0xCE,
                    0x16,
                    0x79
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICJpegFrameEncode
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1F, 0x60, 0x0C, 0x2F,
                    0xC6, 0xD2,
                    0x8C, 0x46,
                    0xAB,
                    0xFA,
                    0x49,
                    0x49,
                    0x5D,
                    0x98,
                    0x3E,
                    0xD1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
