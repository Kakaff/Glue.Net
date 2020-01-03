using System;
using System.Collections.Generic;
using System.Text;

namespace GlueNet.Math
{
    public static class Util
    {
        public static int GetPosition_2D_To_1D(in Vector2i pos, int width) => GetPosition_2D_To_1D(pos.x, pos.y, width);
        public static int GetPosition_2D_To_1D(int x, int y, int width) => y * width + x;

        public static int Interpolate_Linear(int l, int h, float t) => (int)((l * (1f - t)) + (h * t));
        public static float Interpolate_Linear(float l, float h, float t) => (l * (1f - t)) + (h * t);
        public static int Interpolate_BiLinear(int xLyL, int xHyL, int xLyH, int xHyH, float xT, float yT)
            => Interpolate_Linear(
                (int)Interpolate_Linear((float)xLyL, (float)xHyL,xT), 
                (int)Interpolate_Linear((float)xLyH, (float)xHyH,xT), 
                yT);

        public static byte[] Resample_BiLinear(in byte[] orgTex,in Vector2i orgSize, in float scale)
        {
            Vector2i resSize = orgSize * scale;

            byte[] res = new byte[resSize.x * resSize.y];

            for (int y = 0; y < resSize.y; y++)
                for (int x = 0; x < resSize.x; x++)
                {
                    int rPos = GetPosition_2D_To_1D(x,y,resSize.x);
                    
                    float rXT = (x / (float)(resSize.x - 1));
                    float rYT = (y / (float)(resSize.y - 1));

                    float wXTL = (x / (float)resSize.x);
                    float wXTH = (x / (float)(resSize.x - 1));
                    float wYTL = (y / (float)(resSize.y));
                    float wYTH = (y / (float)(resSize.y - 1));

                    float wXT = (wXTH * (orgSize.x - 1)) - (int)(wXTH * (orgSize.x - 1));
                    float wYT = (wYTH * (orgSize.y - 1)) - (int)(wYTH * (orgSize.y - 1));

                    byte xLyL = orgTex[GetPosition_2D_To_1D(
                                      (int)(wXTL * (orgSize.x - 1)),
                                      (int)(wYTL * (orgSize.y - 1)), orgSize.x)];

                    byte xHyL = orgTex[GetPosition_2D_To_1D(
                                      (int)(wXTH * (orgSize.x - 1)),
                                      (int)(wYTL * (orgSize.y - 1)), orgSize.x)];

                    byte xLyH = orgTex[GetPosition_2D_To_1D(
                                      (int)(wXTL * (orgSize.x - 1)),
                                      (int)(wYTH * (orgSize.y - 1)), orgSize.x)];

                    byte xHyH = orgTex[GetPosition_2D_To_1D(
                                      (int)(wXTH * (orgSize.x - 1)),
                                      (int)(wYTH * (orgSize.y - 1)), orgSize.x)];

                    res[rPos] = (byte)Interpolate_BiLinear(xLyL,xHyL,xLyH,xHyH,wXT,wYT);
                }

            return res;
        }
    }
}
