#pragma once

Exported_Function GLFWimage* CreateGLFWImage();
Exported_Function void SetGlfwImageData(GLFWimage* img, const int width, const int height, const uint8_t* pixeldata, const int length);