using System;
using System.Collections.Generic;
using System.Text;

namespace GlueNet.BitFields
{
    public struct BitField_16
    {
        public ushort Value;

        public bool this[int index]
        {
            get => ((Value >> index) & 0x01u) == 0x01u;
            set => Value ^= (ushort)((-Convert.ToInt32(value) ^ Value) & (0x01u << index));
        }


        public override string ToString()
        {
            return Convert.ToString(Value,2).PadLeft(16,'0');
        }

        public BitField_16(ushort v) { Value = v; }

        public static explicit operator BitField_16(in ushort us) => new BitField_16(us);
    }
}
