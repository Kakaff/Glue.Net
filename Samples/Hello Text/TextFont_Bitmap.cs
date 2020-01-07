using GlueNet.Freetype;
using GlueNet.Math;
using GlueNet.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_SDF_Text
{
    public class TextFont_Bitmap : TextFont
    {
        byte[] bitmap;
        Vector2i size;
        Vector2i charLargestSize;
        public override Vector2i Size => size;
        public override Vector2i CharacterGlyphSize => charLargestSize;

        Dictionary<ulong, Character> characters = new Dictionary<ulong, Character>();
        private TextFont_Bitmap() { }

        public TextFont_Bitmap(FT_Face face,Vector2i desiredSize, params char[] chars) : base(chars)
        {
            FT_Char[] ftChars = new FT_Char[chars.Length];
            Vector2i largest = desiredSize;

            face.SetPixelSize((uint)desiredSize.x, (uint)desiredSize.y);

            for (int i = 0; i < chars.Length; i++)
            {
                FT_Char ftc = FT_Char.Load(face, chars[i], (int)FT_LOAD.RENDER);
                largest.x = ftc.Size.x > largest.x ? ftc.Size.x : largest.x;
                largest.y = ftc.Size.y > largest.y ? ftc.Size.y : largest.y;
                ftChars[i] = ftc;
            }
                
            //The size of a single char in the final bitmap.
            Vector2i charBmpSize = new Vector2i((int)Math.Ceiling(largest.x * 0.25f) * 4, (int)Math.Ceiling(largest.y * 0.25f) * 4);
            charLargestSize = charBmpSize;
            //Specifies the grid layout for all the glyphs.
            Vector2i charLayout = new Vector2i((int)Math.Sqrt(chars.Length),
                (int)Math.Ceiling((float)chars.Length / (int)Math.Sqrt(chars.Length)));

            //Final size of the font bitmap.
            Vector2i bmpSize = new Vector2i(charLayout.x * charBmpSize.x,
                charLayout.y * charBmpSize.y);

            size = bmpSize;
            bitmap = new byte[bmpSize.x * bmpSize.y];

            //Add the data to the bitmap.
            for (int i = 0; i < ftChars.Length; i++)
            {
                //Calculate the cell we are going to write the data to.
                int y = (int)(i / (float)charLayout.x);
                int x = (int)(((i / (float)charLayout.x) - y) * charLayout.x);

                //Calculate the offset so that we keep the glyph centered in its cell.
                int xOffset = (int)((charBmpSize.x * (1f - ((float)ftChars[i].Size.x / charBmpSize.x))) * 0.5f);
                int yOffset = (int)((charBmpSize.y * (1f - ((float)ftChars[i].Size.y / charBmpSize.y))) * 0.5f);

                //Calculate where we should start writing the data.
                int sPos = (((y * charBmpSize.y) + yOffset) * bmpSize.x) + (x * charBmpSize.x) + xOffset;

                //Use a variable so we don't need to write ftChars[i] all the god damn time.
                FT_Char ftc = ftChars[i];

                Character c = new Character(ftc,chars[i],
                        new Box2D(
                            new Vector2((float)((x * charBmpSize.x + xOffset) / (double)bmpSize.x), 
                            (float)((y * charBmpSize.y + yOffset) / (double)bmpSize.y)),
                            new Vector2((float)((x * charBmpSize.x + xOffset +  ftc.Size.x) / (double)bmpSize.x), 
                            (float)((y * charBmpSize.y + yOffset + ftc.Size.y) / (double)bmpSize.y))
                        )
                    );
                characters.Add(chars[i],c);

                byte[] charBitmap = ftc.Bitmap; //Grab the bitmap for the character.

                //Write it to the final bitmap
                for (int _y = 0; _y < ftc.Size.y; _y++)
                    for (int _x = 0; _x < ftc.Size.x; _x++)
                        bitmap[sPos + (_y * bmpSize.x) + _x] = charBitmap[_x + (_y * ftc.Size.x)];
                
            }
        }

        public override Character GetCharacter(ulong characterCode)
        {
            characters.TryGetValue(characterCode, out Character c);
            return c;
        }

        public override Texture2D CreateTexture2D()
        {
            Console.WriteLine("Creating Texture2D");
            Texture2D tex = new Texture2D();
            Console.WriteLine("Binding Texture");
            tex.Bind(0);
            if (!GL.glGetError(out uint err))
                Console.WriteLine($"GL ERROR: {err}");
            Console.WriteLine("Setting PixelData");
            tex.SetTextureData(0, GL.GL_RED, Size.x, Size.y, 0, GL.GL_RED, GL.GL_UNSIGNED_BYTE, bitmap);
            if (!GL.glGetError(out err))
                Console.WriteLine($"GL ERROR: {err}");

            return tex;
        }
    }
}
