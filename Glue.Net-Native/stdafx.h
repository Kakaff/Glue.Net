// stdafx.h : include file for standard system include files,
// or project specific include files that are used frequently, but
// are changed infrequently
//

#pragma once
#define WIN32_LEAN_AND_MEAN             // Exclude rarely-used stuff from Windows headers
// Windows Header Files
#include <windows.h>


#define GLFW_DLL
#define Exported_Function extern"C" __declspec(dllexport)

#include "targetver.h"

#include <GLFW/glfw3.h>

#include <ft2build.h>
#include FT_FREETYPE_H
