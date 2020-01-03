#include "stdafx.h"
#include "FTInit.h"


FT_Library* InitFreeType(int* err) {
	FT_Library* lib = new FT_Library();
	*err = FT_Init_FreeType(lib);
	return lib;
}