#pragma once
Exported_Function FT_Error CreateFT_FACE(FT_Library* lib, char* path, int index, FT_Face* face);

Exported_Function void DestroyFT_FACE(FT_Face* face);

Exported_Function FT_Error FTFACE_Set_PixelSize(FT_Face* face, unsigned int width, unsigned int height);

Exported_Function FT_Face* Create_FT_FACE_Handle(void);