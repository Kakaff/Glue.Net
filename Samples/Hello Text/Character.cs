using GlueNet.Freetype;
using GlueNet.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_SDF_Text
{
    public readonly struct Character
    {
        public readonly Box2D UvBox;
        public readonly Vector2i Size;
        public readonly Vector2i Bearing;
        public readonly uint Advance;
        public readonly ulong Char;

        internal Character(in FT_Char c, in ulong characterCode, in Box2D uvBox)
        {
            Size = c.Size;
            Bearing = c.Bearing;
            Advance = c.Advance;
            UvBox = uvBox;
            Char = characterCode;
        }

        public Vector2i[] GetMeshVertices(Vector2i pos)
        {
            Vector2i modOrigin = new Vector2i((pos.x >> 6) + Bearing.x, pos.y - (Size.y - Bearing.y));

            return new Vector2i[] {
                    modOrigin,
                    modOrigin + new Vector2i(0,Size.y),
                    modOrigin + Size ,
                    modOrigin + new Vector2i(Size.x,0)};
        }
    }
}
