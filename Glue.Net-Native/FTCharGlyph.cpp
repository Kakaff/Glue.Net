#include "stdafx.h"
#include "FTCharGlyph.h"

int FTChar_Load(FT_Face* face, uint64_t c, int32_t flags) {
	return FT_Load_Char(*face, c, flags);
}

void FTGlyph_GetInfo(FT_Face* face, int* size, int* bearing, int64_t* advance) {
	FT_Face f = *face;
	size[0] = f->glyph->bitmap.width;
	size[1] = f->glyph->bitmap.rows;

	bearing[0] = f->glyph->bitmap_left;
	bearing[1] = f->glyph->bitmap_top;

	*advance = f->glyph->advance.x;
}

void FTGlyph_GetBitmap(FT_Face* face, uint8_t* bitmap) {
	FT_Face f = *face;
	
	memcpy(bitmap, f->glyph->bitmap.buffer, f->glyph->bitmap.rows * f->glyph->bitmap.width);
}