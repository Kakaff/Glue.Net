#include "stdafx.h"
#include "GammaRamp.h"

GLFWgammaramp* CreateGammaRamp() {
	return new GLFWgammaramp();
}

GLFWgammaramp* CreateGammaRampClone(GLFWgammaramp* ramp) {
	GLFWgammaramp* r = new GLFWgammaramp();
	r->blue = new uint16_t[ramp->size];
	r->green = new uint16_t[ramp->size];
	r->red = new uint16_t[ramp->size];
	r->size = ramp->size;

	memcpy(r->red, ramp->red, ramp->size * 2);
	memcpy(r->green, ramp->green, ramp->size * 2);
	memcpy(r->blue, ramp->blue, ramp->size * 2);
	return r;
}

void DestroyGammaRamp(GLFWgammaramp* handle) {
	delete[] handle->blue;
	delete[] handle->red;
	delete[] handle->green;
	delete handle;
}

void UpdateGammaRampValues(GLFWgammaramp* handle, uint16_t* red, uint16_t* green, uint16_t* blue, uint32_t size) {
	delete[] handle->red;
	delete[] handle->green;
	delete[] handle->blue;
	handle->red = new uint16_t[size];
	handle->green = new uint16_t[size];
	handle->blue = new uint16_t[size];
	memcpy(handle->red, red, size * 2);
	memcpy(handle->green, green, size * 2);
	memcpy(handle->blue, blue, size * 2);
	handle->size = size;
}

void GetGammaRampValues(GLFWgammaramp* handle, uint16_t* red, uint16_t* green, uint16_t* blue, uint32_t &size) {
	red = handle->red;
	blue = handle->blue;
	green = handle->green;
	size = handle->size;
}