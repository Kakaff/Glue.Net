#pragma once

Exported_Function GLFWgammaramp* CreateGammaRamp();
Exported_Function GLFWgammaramp* CreateGammaRampClone(GLFWgammaramp* ramp);
Exported_Function void DestroyGammaRamp(GLFWgammaramp* handle);
Exported_Function void UpdateGammaRampValues(GLFWgammaramp* handle, uint16_t* red, uint16_t* green, uint16_t* blue, uint32_t size);
Exported_Function void GetGammaRampValues(GLFWgammaramp* handle, uint16_t* red, uint16_t* green, uint16_t* blue, uint32_t &size);
