using System;
using System.Collections.Generic;
using System.Text;

namespace GlueNet.BitFields
{
    public struct BitField_32
    {
        public uint Value;

        public bool this[int index]
        {
            get => ((Value >> index) & 0x01u) == 0x01u;
            set => Value ^= (uint)((-Convert.ToInt32(value) ^ Value) & (0x01u << index));
        }


        public override string ToString()
        {
            return Convert.ToString(Value, 2).PadLeft(32, '0');
        }

        public BitField_32(uint v) { Value = v; }

        public static explicit operator BitField_32(in uint ui) => new BitField_32(ui);
    }
}
