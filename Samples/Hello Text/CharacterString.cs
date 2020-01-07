using GlueNet.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_SDF_Text
{
    public class CharacterString
    {
        Character[] characters;
        int length;
        public Vector2i Size => size;
        Vector2i size; //The size of the string in pixels.

        TextFont textFont;

        public CharacterString(TextFont tf, string s)
        {
            textFont = tf;
            ReplaceCharacters(s);
        }

        public void ReplaceCharacters(string s)
        {
            if (characters == null || characters.Length < s.Length)
                characters = new Character[s.Length + 8];

            for (int i = 0; i < s.Length; i++)
                characters[i] = textFont.GetCharacter(s[i]);

            length = s.Length;

            CalculateSize();
        }
        public void ReplaceCharacters(string s, TextFont tf)
        {
            textFont = tf;
            ReplaceCharacters(s);
        }

        public void CalculateSize()
        {
            int x = 0, y = 0;

            for (int i = 0; i < length; i++)
            {
                x += i < characters.Length - 1 ? (int)characters[i].Advance : characters[i].Size.x << 6;
                y = characters[i].Size.y > y ? characters[i].Size.y : y;
            }

            x >>= 6;

            size = new Vector2i(x, y);
        }

        public float[] GetVertexData(Vector2i p, int pStart = 0, float lineSpacing = 1.1f, int maxLineLength = int.MaxValue)
        {
            List<float> resArr = new List<float>();
            int lSpacing = (int)(textFont.CharacterGlyphSize.y * lineSpacing);

            p = new Vector2i(p.x, p.y - lSpacing);
            for (int i = 0; i < length; i++)
            {
                Character c = characters[i];
                //if char is ' ' add it.
                //if char is '\n' add a new line.
                //otherwise it is most likely a word and we need to check the size of it.

                if (c.Char == ' ')
                {
                    if ((p.x + c.Advance) >> 6 < maxLineLength)
                        AddCharacter(c);
                }
                else if (c.Char == '\n')
                    NewLine();
                else
                {
                    int wSize = 0;
                    int j = i;
                    for (; j < length; j++)
                    {
                        c = characters[j];

                        if (c.Char == ' ' || c.Char == '\n')
                            break;
                        else
                            wSize += (int)c.Advance;
                    }


                    //Check if the word fits on the current line, if it doesn't but is shorter than the maxLineLength create a new line. This can and should be refined further
                    if ((p.x + wSize) >> 6 > maxLineLength && (wSize >> 6) <= maxLineLength)
                        NewLine();

                    for (int y = i; y < j; y++)
                        AddCharacter(characters[y]);


                    i = j - 1;

                }

                void NewLine()
                {
                    p.x = pStart;
                    p.y -= lSpacing;
                }

                void AddCharacter(in Character character)
                {
                    Vector2i[] verts = character.GetMeshVertices(p);
                    Vector2[] uvs = character.UvBox.ToUvCoordinates();

                    for (int o = 0; o < 4; o++)
                    {
                        resArr.Add((float)verts[o].x);
                        resArr.Add((float)verts[o].y);
                        resArr.Add(uvs[o].x);
                        resArr.Add(uvs[o].y);
                    }

                    p.x += (int)character.Advance;
                }
            }
            return resArr.ToArray();
        }
    }
}
