using System;
using System.Collections.Generic;
using System.Text;

namespace GlueNet.BitFields
{
    public struct BitField_8
    {
        public byte Value;

        public bool this[int index]
        {
            get => ((Value >> index) & 0x01u) == 0x01u;
            set => Value ^= (byte)((-Convert.ToInt32(value) ^ Value) & (0x01u << index));
        }


        public override string ToString()
        {
            return Convert.ToString(Value, 2).PadLeft(8, '0');
        }

        public BitField_8(byte b) { Value = b; }

        public static explicit operator BitField_8 (in byte b) => new BitField_8(b);
    }
}
