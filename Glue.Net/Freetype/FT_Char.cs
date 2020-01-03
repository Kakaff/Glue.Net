using GlueNet.Math;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace GlueNet.Freetype
{

    public enum FT_LOAD : long
    {
        //Copied directly from https://www.freetype.org/freetype2/docs/reference/ft2-base_interface.html#ft_load_render
        DEFAULT =  0x0,
        NO_SCALE                     =  ( 1L << 0 ),
        NO_HINTING                   =  ( 1L << 1 ),
        RENDER                       =  ( 1L << 2 ),
        NO_BITMAP                    =  ( 1L << 3 ),
        VERTICAL_LAYOUT              =  ( 1L << 4 ),
        FORCE_AUTOHINT               =  ( 1L << 5 ),
        CROP_BITMAP                  =  ( 1L << 6 ),
        PEDANTIC                     =  ( 1L << 7 ),
        IGNORE_GLOBAL_ADVANCE_WIDTH  =  ( 1L << 9 ),
        NO_RECURSE                   =  ( 1L << 10 ),
        IGNORE_TRANSFORM             =  ( 1L << 11 ),
        MONOCHROME                   =  ( 1L << 12 ),
        LINEAR_DESIGN                =  ( 1L << 13 ),
        NO_AUTOHINT                  =  ( 1L << 15 ),
        /* Bits 16-19 are used by `FT_LOAD_TARGET_` */
        COLOR                        =  ( 1L << 20 ),
        COMPUTE_METRICS              =  ( 1L << 21 ),
        BITMAP_METRICS_ONLY          =  ( 1L << 22 ),
    }

    public sealed class FT_Char
    {
        public Vector2i Size => size;
        public Vector2i Bearing => bearing;
        public uint Advance => advance;

        Vector2i size,bearing;
        uint advance;
        byte[] bitmap;

        public byte[] Bitmap => bitmap;
        private FT_Char() { }

        public static unsafe FT_Char Load(FT_Face face,ulong charCode, int flags)
        {
            FT_Char ftc = new FT_Char();

            __FTChar_Load(face.handle, charCode, flags);

            long adv = 0;
            fixed(int* sPtr = &ftc.size.x)
                fixed (int* bPtr = &ftc.bearing.x)
                    __FTGlyph_Get_Info(face.handle, sPtr, bPtr, out adv);

            ftc.advance = (uint)adv;

            ftc.bitmap = new byte[ftc.size.x * ftc.size.y];

            fixed (byte* bmpPtr = ftc.bitmap)
                __FTGlyph_Get_Bitmap(face.handle,bmpPtr);
            return ftc;
        }


        [DllImport("Glue.Net-Native.dll",
            CharSet = CharSet.Ansi,
            CallingConvention = CallingConvention.StdCall,
            EntryPoint = "FTChar_Load"), SuppressUnmanagedCodeSecurity]
        static extern int __FTChar_Load(IntPtr face, ulong charCode, int flags);

        [DllImport("Glue.Net-Native.dll",
            CharSet = CharSet.Ansi,
            CallingConvention = CallingConvention.StdCall,
            EntryPoint = "FTGlyph_GetInfo"), SuppressUnmanagedCodeSecurity]
        static extern unsafe void __FTGlyph_Get_Info(IntPtr face,int* size, int* bearing, out long advance);

        [DllImport("Glue.Net-Native.dll",
            CharSet = CharSet.Ansi,
            CallingConvention = CallingConvention.StdCall,
            EntryPoint = "FTGlyph_GetBitmap"), SuppressUnmanagedCodeSecurity]
        static extern unsafe void __FTGlyph_Get_Bitmap(IntPtr face, byte* bitmap);
    }
}
