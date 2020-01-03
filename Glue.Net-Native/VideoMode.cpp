#include "stdafx.h"
#include "VideoMode.h"

void GetVideoModeValues(const GLFWvidmode* vm, int* width, int* height, int* red, int* green, int* blue, int* refresh) {
	*width = vm->width;
	*height = vm->height;
	*red = vm->redBits;
	*green = vm->greenBits;
	*blue = vm->blueBits;
	*refresh = vm->refreshRate;
}

const GLFWvidmode** GetVideoModes(GLFWmonitor* monitor, int* count) {
	*count = 25;

	const GLFWvidmode* vidmodes = glfwGetVideoModes(monitor,count);

	int c = *count;
	const GLFWvidmode** arr = new const GLFWvidmode*[c];
	for (int i = 0; i < c; i++)
		arr[i] = &vidmodes[i];


	return arr;
}

void DeleteVideoModeArr(const GLFWvidmode** arr) {
	delete(arr);
}