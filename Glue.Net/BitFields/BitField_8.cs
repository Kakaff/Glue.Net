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
            get => ((Value >> index) & 0x01) == 0x01;
            set => Value = value ? Value |= (byte)(0x01 << index) : Value &= (byte)(0xFF ^ (0x01 << index));
        }

        public static explicit operator BitField_8 (in byte b)
        {
            BitField_8 bf = new BitField_8();
            bf.Value = b;
            return bf;
        }
    }
}
