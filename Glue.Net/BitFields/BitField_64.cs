using System;
using System.Collections.Generic;
using System.Text;

namespace GlueNet.BitFields
{
    public struct BitField_64
    {
        public ulong Value;

        public bool this[int index]
        {
            get => ((Value >> index) & 0x01u) == 0x01u;
            set => Value ^= (((ulong)-Convert.ToInt64(value) ^ Value) & (0x01u << index));
        }


        public override string ToString()
        {
            return Convert.ToString((long)Value, 2).PadLeft(64, '0');
        }

        public BitField_64(ulong v) { Value = v; }

        public static explicit operator BitField_64(in ulong ul) => new BitField_64(ul);
    }
}
