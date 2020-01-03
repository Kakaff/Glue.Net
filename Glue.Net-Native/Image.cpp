#include "stdafx.h"
#include "Image.h"

GLFWimage* CreateIconArray(GLFWimage** arr, int length) {
	GLFWimage* iconArr = new GLFWimage[length];
	for (int i = 0; i < length; i++)
		iconArr[i] = *arr[i];

	return iconArr;
}

void DeleteWindowIconArr(GLFWimage* arr) {
	delete[] arr;
}