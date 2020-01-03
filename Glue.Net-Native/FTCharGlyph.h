#pragma once
Exported_Function int FTChar_Load(FT_Face* face, uint64_t c, int32_t flags);
Exported_Function void FTGlyph_GetInfo(FT_Face* face, int* size, int* bearing, int64_t* advance);
Exported_Function void FTGlyph_GetBitmap(FT_Face* face, uint8_t* bitmap);