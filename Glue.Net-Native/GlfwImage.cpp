#include "stdafx.h"
#include "GlfwImage.h"

GLFWimage* CreateGLFWImage() {
	return new GLFWimage();
}

void SetGlfwImageData(GLFWimage* img, const int width, const int height, const uint8_t* pixeldata, const int length) {
	if (img->pixels != nullptr)
		delete[] img->pixels;

	img->pixels = new uint8_t[length];
	memcpy(img->pixels, pixeldata, length);
	img->width = width;
	img->height = height;
}