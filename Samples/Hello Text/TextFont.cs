using GlueNet.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_SDF_Text
{
    public abstract class TextFont
    {
        public string SupportedCharacters { get; }
        public abstract Vector2i CharacterGlyphSize { get; }
        public abstract Vector2i Size { get; }
        private TextFont() { }
        protected TextFont(params char[] chars) { SupportedCharacters = new string(chars); }

        public abstract Texture2D CreateTexture2D();

        public abstract Character GetCharacter(ulong charactercode);

    }
}
