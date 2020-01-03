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
            set => Value = value ? Value |= 0x01u << index : Value &= 0xFFFF_FFFFu ^ (0x01u << index);
        }
    }
}
