// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HANDLE
    {
        public readonly void* Value;

        public HANDLE(void* value)
        {
            Value = value;
        }

        public static HANDLE INVALID_VALUE => new HANDLE((void*)(-1));

        public static HANDLE NULL => new HANDLE(null);

        public static bool operator ==(HANDLE left, HANDLE right) => left.Value == right.Value;

        public static bool operator !=(HANDLE left, HANDLE right) => left.Value != right.Value;

        public static bool operator <(HANDLE left, HANDLE right) => left.Value < right.Value;

        public static bool operator <=(HANDLE left, HANDLE right) => left.Value <= right.Value;

        public static bool operator >(HANDLE left, HANDLE right) => left.Value > right.Value;

        public static bool operator >=(HANDLE left, HANDLE right) => left.Value >= right.Value;

        public static explicit operator HANDLE(void* value) => new HANDLE(value);

        public static implicit operator void*(HANDLE value) => value.Value;

        public static explicit operator HANDLE(byte value) => new HANDLE((void*)(value));

        public static explicit operator byte(HANDLE value) => (byte)(value.Value);

        public static explicit operator HANDLE(short value) => new HANDLE((void*)(value));

        public static explicit operator short(HANDLE value) => (short)(value.Value);

        public static explicit operator HANDLE(int value) => new HANDLE((void*)(value));

        public static explicit operator int(HANDLE value) => (int)(value.Value);

        public static explicit operator HANDLE(long value) => new HANDLE((void*)(value));

        public static explicit operator long(HANDLE value) => (long)(value.Value);

        public static explicit operator HANDLE(nint value) => new HANDLE((void*)(value));

        public static implicit operator nint(HANDLE value) => (nint)(value.Value);

        public static explicit operator HANDLE(sbyte value) => new HANDLE((void*)(value));

        public static explicit operator sbyte(HANDLE value) => (sbyte)(value.Value);

        public static explicit operator HANDLE(ushort value) => new HANDLE((void*)(value));

        public static explicit operator ushort(HANDLE value) => (ushort)(value.Value);

        public static explicit operator HANDLE(uint value) => new HANDLE((void*)(value));

        public static explicit operator uint(HANDLE value) => (uint)(value.Value);

        public static explicit operator HANDLE(ulong value) => new HANDLE((void*)(value));

        public static explicit operator ulong(HANDLE value) => (ulong)(value.Value);

        public static explicit operator HANDLE(nuint value) => new HANDLE((void*)(value));

        public static implicit operator nuint(HANDLE value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HANDLE other) && ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
