#include "stdafx.h"
#include "GlueInit.h"

bool InitGlfw(void) {
	return glfwInit() == GLFW_TRUE;
}

void TerminateGlfw(void) {
	glfwTerminate();
}