#include "stdafx.h"
#include "FTFace.h"

FT_Error CreateFT_FACE(FT_Library* lib, char* path,int index, FT_Face* face) {

	return FT_New_Face(*lib, path, index, face);
}

void DestroyFT_FACE(FT_Face* face) {
	FT_Done_Face(*face);
	delete(face);
}

FT_Error FTFACE_Set_PixelSize(FT_Face* face, unsigned int width, unsigned int height) {
	return FT_Set_Pixel_Sizes(*face, width, height);
}

FT_Face* Create_FT_FACE_Handle(void) { return new FT_Face(); }


