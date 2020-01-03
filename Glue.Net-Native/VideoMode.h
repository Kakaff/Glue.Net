#pragma once

Exported_Function const GLFWvidmode** GetVideoModes(GLFWmonitor *monitor,int* count);
Exported_Function void GetVideoModeValues(const GLFWvidmode* vm, int* width, int* height, int* red, int* green, int* blue, int* refresh);
Exported_Function void DeleteVideoModeArr(const GLFWvidmode** arr);