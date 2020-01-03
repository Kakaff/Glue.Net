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
            set => Value = value ? Value |= (ushort)(0x01u << index) : Value &= (ushort)(0xFFFFu ^ (0x01u << index));
        }
    }
}
