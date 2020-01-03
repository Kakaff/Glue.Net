using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL
{

    public static partial class GL
    {

        internal static void Init(glInitHint initHint)
        {
            switch (initHint)
            {
                case glInitHint.GL_VERSION_1_1:
                    {
                        __GlueAccum = GLFunctionLoader.LoadGLFunction<__glAccum>("glAccum");
                        __GlueAlphaFunc = GLFunctionLoader.LoadGLFunction<__glAlphaFunc>("glAlphaFunc");
                        __GlueAreTexturesResident = GLFunctionLoader.LoadGLFunction<__glAreTexturesResident>("glAreTexturesResident");
                        __GlueArrayElement = GLFunctionLoader.LoadGLFunction<__glArrayElement>("glArrayElement");
                        __GlueBegin = GLFunctionLoader.LoadGLFunction<__glBegin>("glBegin");
                        __GlueBindTexture = GLFunctionLoader.LoadGLFunction<__glBindTexture>("glBindTexture");
                        __GlueBitmap = GLFunctionLoader.LoadGLFunction<__glBitmap>("glBitmap");
                        __GlueBlendFunc = GLFunctionLoader.LoadGLFunction<__glBlendFunc>("glBlendFunc");
                        __GlueCallList = GLFunctionLoader.LoadGLFunction<__glCallList>("glCallList");
                        __GlueCallLists = GLFunctionLoader.LoadGLFunction<__glCallLists>("glCallLists");
                        __GlueClear = GLFunctionLoader.LoadGLFunction<__glClear>("glClear");
                        __GlueClearAccum = GLFunctionLoader.LoadGLFunction<__glClearAccum>("glClearAccum");
                        __GlueClearColor = GLFunctionLoader.LoadGLFunction<__glClearColor>("glClearColor");
                        __GlueClearDepth = GLFunctionLoader.LoadGLFunction<__glClearDepth>("glClearDepth");
                        __GlueClearIndex = GLFunctionLoader.LoadGLFunction<__glClearIndex>("glClearIndex");
                        __GlueClearStencil = GLFunctionLoader.LoadGLFunction<__glClearStencil>("glClearStencil");
                        __GlueClipPlane = GLFunctionLoader.LoadGLFunction<__glClipPlane>("glClipPlane");
                        __GlueColor3b = GLFunctionLoader.LoadGLFunction<__glColor3b>("glColor3b");
                        __GlueColor3bv = GLFunctionLoader.LoadGLFunction<__glColor3bv>("glColor3bv");
                        __GlueColor3d = GLFunctionLoader.LoadGLFunction<__glColor3d>("glColor3d");
                        __GlueColor3dv = GLFunctionLoader.LoadGLFunction<__glColor3dv>("glColor3dv");
                        __GlueColor3f = GLFunctionLoader.LoadGLFunction<__glColor3f>("glColor3f");
                        __GlueColor3fv = GLFunctionLoader.LoadGLFunction<__glColor3fv>("glColor3fv");
                        __GlueColor3i = GLFunctionLoader.LoadGLFunction<__glColor3i>("glColor3i");
                        __GlueColor3iv = GLFunctionLoader.LoadGLFunction<__glColor3iv>("glColor3iv");
                        __GlueColor3s = GLFunctionLoader.LoadGLFunction<__glColor3s>("glColor3s");
                        __GlueColor3sv = GLFunctionLoader.LoadGLFunction<__glColor3sv>("glColor3sv");
                        __GlueColor3ub = GLFunctionLoader.LoadGLFunction<__glColor3ub>("glColor3ub");
                        __GlueColor3ubv = GLFunctionLoader.LoadGLFunction<__glColor3ubv>("glColor3ubv");
                        __GlueColor3ui = GLFunctionLoader.LoadGLFunction<__glColor3ui>("glColor3ui");
                        __GlueColor3uiv = GLFunctionLoader.LoadGLFunction<__glColor3uiv>("glColor3uiv");
                        __GlueColor3us = GLFunctionLoader.LoadGLFunction<__glColor3us>("glColor3us");
                        __GlueColor3usv = GLFunctionLoader.LoadGLFunction<__glColor3usv>("glColor3usv");
                        __GlueColor4b = GLFunctionLoader.LoadGLFunction<__glColor4b>("glColor4b");
                        __GlueColor4bv = GLFunctionLoader.LoadGLFunction<__glColor4bv>("glColor4bv");
                        __GlueColor4d = GLFunctionLoader.LoadGLFunction<__glColor4d>("glColor4d");
                        __GlueColor4dv = GLFunctionLoader.LoadGLFunction<__glColor4dv>("glColor4dv");
                        __GlueColor4f = GLFunctionLoader.LoadGLFunction<__glColor4f>("glColor4f");
                        __GlueColor4fv = GLFunctionLoader.LoadGLFunction<__glColor4fv>("glColor4fv");
                        __GlueColor4i = GLFunctionLoader.LoadGLFunction<__glColor4i>("glColor4i");
                        __GlueColor4iv = GLFunctionLoader.LoadGLFunction<__glColor4iv>("glColor4iv");
                        __GlueColor4s = GLFunctionLoader.LoadGLFunction<__glColor4s>("glColor4s");
                        __GlueColor4sv = GLFunctionLoader.LoadGLFunction<__glColor4sv>("glColor4sv");
                        __GlueColor4ub = GLFunctionLoader.LoadGLFunction<__glColor4ub>("glColor4ub");
                        __GlueColor4ubv = GLFunctionLoader.LoadGLFunction<__glColor4ubv>("glColor4ubv");
                        __GlueColor4ui = GLFunctionLoader.LoadGLFunction<__glColor4ui>("glColor4ui");
                        __GlueColor4uiv = GLFunctionLoader.LoadGLFunction<__glColor4uiv>("glColor4uiv");
                        __GlueColor4us = GLFunctionLoader.LoadGLFunction<__glColor4us>("glColor4us");
                        __GlueColor4usv = GLFunctionLoader.LoadGLFunction<__glColor4usv>("glColor4usv");
                        __GlueColorMask = GLFunctionLoader.LoadGLFunction<__glColorMask>("glColorMask");
                        __GlueColorMaterial = GLFunctionLoader.LoadGLFunction<__glColorMaterial>("glColorMaterial");
                        __GlueColorPointer = GLFunctionLoader.LoadGLFunction<__glColorPointer>("glColorPointer");
                        __GlueCopyPixels = GLFunctionLoader.LoadGLFunction<__glCopyPixels>("glCopyPixels");
                        __GlueCopyTexImage1D = GLFunctionLoader.LoadGLFunction<__glCopyTexImage1D>("glCopyTexImage1D");
                        __GlueCopyTexImage2D = GLFunctionLoader.LoadGLFunction<__glCopyTexImage2D>("glCopyTexImage2D");
                        __GlueCopyTexSubImage1D = GLFunctionLoader.LoadGLFunction<__glCopyTexSubImage1D>("glCopyTexSubImage1D");
                        __GlueCopyTexSubImage2D = GLFunctionLoader.LoadGLFunction<__glCopyTexSubImage2D>("glCopyTexSubImage2D");
                        __GlueCullFace = GLFunctionLoader.LoadGLFunction<__glCullFace>("glCullFace");
                        __GlueDeleteLists = GLFunctionLoader.LoadGLFunction<__glDeleteLists>("glDeleteLists");
                        __GlueDeleteTextures = GLFunctionLoader.LoadGLFunction<__glDeleteTextures>("glDeleteTextures");
                        __GlueDepthFunc = GLFunctionLoader.LoadGLFunction<__glDepthFunc>("glDepthFunc");
                        __GlueDepthMask = GLFunctionLoader.LoadGLFunction<__glDepthMask>("glDepthMask");
                        __GlueDepthRange = GLFunctionLoader.LoadGLFunction<__glDepthRange>("glDepthRange");
                        __GlueDisable = GLFunctionLoader.LoadGLFunction<__glDisable>("glDisable");
                        __GlueDisableClientState = GLFunctionLoader.LoadGLFunction<__glDisableClientState>("glDisableClientState");
                        __GlueDrawArrays = GLFunctionLoader.LoadGLFunction<__glDrawArrays>("glDrawArrays");
                        __GlueDrawBuffer = GLFunctionLoader.LoadGLFunction<__glDrawBuffer>("glDrawBuffer");
                        __GlueDrawElements = GLFunctionLoader.LoadGLFunction<__glDrawElements>("glDrawElements");
                        __GlueDrawPixels = GLFunctionLoader.LoadGLFunction<__glDrawPixels>("glDrawPixels");
                        __GlueEdgeFlag = GLFunctionLoader.LoadGLFunction<__glEdgeFlag>("glEdgeFlag");
                        __GlueEdgeFlagPointer = GLFunctionLoader.LoadGLFunction<__glEdgeFlagPointer>("glEdgeFlagPointer");
                        __GlueEdgeFlagv = GLFunctionLoader.LoadGLFunction<__glEdgeFlagv>("glEdgeFlagv");
                        __GlueEnable = GLFunctionLoader.LoadGLFunction<__glEnable>("glEnable");
                        __GlueEnableClientState = GLFunctionLoader.LoadGLFunction<__glEnableClientState>("glEnableClientState");
                        __GlueEnd = GLFunctionLoader.LoadGLFunction<__glEnd>("glEnd");
                        __GlueEndList = GLFunctionLoader.LoadGLFunction<__glEndList>("glEndList");
                        __GlueEvalCoord1d = GLFunctionLoader.LoadGLFunction<__glEvalCoord1d>("glEvalCoord1d");
                        __GlueEvalCoord1dv = GLFunctionLoader.LoadGLFunction<__glEvalCoord1dv>("glEvalCoord1dv");
                        __GlueEvalCoord1f = GLFunctionLoader.LoadGLFunction<__glEvalCoord1f>("glEvalCoord1f");
                        __GlueEvalCoord1fv = GLFunctionLoader.LoadGLFunction<__glEvalCoord1fv>("glEvalCoord1fv");
                        __GlueEvalCoord2d = GLFunctionLoader.LoadGLFunction<__glEvalCoord2d>("glEvalCoord2d");
                        __GlueEvalCoord2dv = GLFunctionLoader.LoadGLFunction<__glEvalCoord2dv>("glEvalCoord2dv");
                        __GlueEvalCoord2f = GLFunctionLoader.LoadGLFunction<__glEvalCoord2f>("glEvalCoord2f");
                        __GlueEvalCoord2fv = GLFunctionLoader.LoadGLFunction<__glEvalCoord2fv>("glEvalCoord2fv");
                        __GlueEvalMesh1 = GLFunctionLoader.LoadGLFunction<__glEvalMesh1>("glEvalMesh1");
                        __GlueEvalMesh2 = GLFunctionLoader.LoadGLFunction<__glEvalMesh2>("glEvalMesh2");
                        __GlueEvalPoint1 = GLFunctionLoader.LoadGLFunction<__glEvalPoint1>("glEvalPoint1");
                        __GlueEvalPoint2 = GLFunctionLoader.LoadGLFunction<__glEvalPoint2>("glEvalPoint2");
                        __GlueFeedbackBuffer = GLFunctionLoader.LoadGLFunction<__glFeedbackBuffer>("glFeedbackBuffer");
                        __GlueFinish = GLFunctionLoader.LoadGLFunction<__glFinish>("glFinish");
                        __GlueFlush = GLFunctionLoader.LoadGLFunction<__glFlush>("glFlush");
                        __GlueFogf = GLFunctionLoader.LoadGLFunction<__glFogf>("glFogf");
                        __GlueFogfv = GLFunctionLoader.LoadGLFunction<__glFogfv>("glFogfv");
                        __GlueFogi = GLFunctionLoader.LoadGLFunction<__glFogi>("glFogi");
                        __GlueFogiv = GLFunctionLoader.LoadGLFunction<__glFogiv>("glFogiv");
                        __GlueFrontFace = GLFunctionLoader.LoadGLFunction<__glFrontFace>("glFrontFace");
                        __GlueFrustum = GLFunctionLoader.LoadGLFunction<__glFrustum>("glFrustum");
                        __GlueGenLists = GLFunctionLoader.LoadGLFunction<__glGenLists>("glGenLists");
                        __GlueGenTextures = GLFunctionLoader.LoadGLFunction<__glGenTextures>("glGenTextures");
                        __GlueGetBooleanv = GLFunctionLoader.LoadGLFunction<__glGetBooleanv>("glGetBooleanv");
                        __GlueGetClipPlane = GLFunctionLoader.LoadGLFunction<__glGetClipPlane>("glGetClipPlane");
                        __GlueGetDoublev = GLFunctionLoader.LoadGLFunction<__glGetDoublev>("glGetDoublev");
                        __GlueGetError = GLFunctionLoader.LoadGLFunction<__glGetError>("glGetError");
                        __GlueGetFloatv = GLFunctionLoader.LoadGLFunction<__glGetFloatv>("glGetFloatv");
                        __GlueGetIntegerv = GLFunctionLoader.LoadGLFunction<__glGetIntegerv>("glGetIntegerv");
                        __GlueGetLightfv = GLFunctionLoader.LoadGLFunction<__glGetLightfv>("glGetLightfv");
                        __GlueGetLightiv = GLFunctionLoader.LoadGLFunction<__glGetLightiv>("glGetLightiv");
                        __GlueGetMapdv = GLFunctionLoader.LoadGLFunction<__glGetMapdv>("glGetMapdv");
                        __GlueGetMapfv = GLFunctionLoader.LoadGLFunction<__glGetMapfv>("glGetMapfv");
                        __GlueGetMapiv = GLFunctionLoader.LoadGLFunction<__glGetMapiv>("glGetMapiv");
                        __GlueGetMaterialfv = GLFunctionLoader.LoadGLFunction<__glGetMaterialfv>("glGetMaterialfv");
                        __GlueGetMaterialiv = GLFunctionLoader.LoadGLFunction<__glGetMaterialiv>("glGetMaterialiv");
                        __GlueGetPixelMapfv = GLFunctionLoader.LoadGLFunction<__glGetPixelMapfv>("glGetPixelMapfv");
                        __GlueGetPixelMapuiv = GLFunctionLoader.LoadGLFunction<__glGetPixelMapuiv>("glGetPixelMapuiv");
                        __GlueGetPixelMapusv = GLFunctionLoader.LoadGLFunction<__glGetPixelMapusv>("glGetPixelMapusv");
                        __GlueGetPointerv = GLFunctionLoader.LoadGLFunction<__glGetPointerv>("glGetPointerv");
                        __GlueGetPolygonStipple = GLFunctionLoader.LoadGLFunction<__glGetPolygonStipple>("glGetPolygonStipple");
                        __GlueGetString = GLFunctionLoader.LoadGLFunction<__glGetString>("glGetString");
                        __GlueGetTexEnvfv = GLFunctionLoader.LoadGLFunction<__glGetTexEnvfv>("glGetTexEnvfv");
                        __GlueGetTexEnviv = GLFunctionLoader.LoadGLFunction<__glGetTexEnviv>("glGetTexEnviv");
                        __GlueGetTexGendv = GLFunctionLoader.LoadGLFunction<__glGetTexGendv>("glGetTexGendv");
                        __GlueGetTexGenfv = GLFunctionLoader.LoadGLFunction<__glGetTexGenfv>("glGetTexGenfv");
                        __GlueGetTexGeniv = GLFunctionLoader.LoadGLFunction<__glGetTexGeniv>("glGetTexGeniv");
                        __GlueGetTexImage = GLFunctionLoader.LoadGLFunction<__glGetTexImage>("glGetTexImage");
                        __GlueGetTexLevelParameterfv = GLFunctionLoader.LoadGLFunction<__glGetTexLevelParameterfv>("glGetTexLevelParameterfv");
                        __GlueGetTexLevelParameteriv = GLFunctionLoader.LoadGLFunction<__glGetTexLevelParameteriv>("glGetTexLevelParameteriv");
                        __GlueGetTexParameterfv = GLFunctionLoader.LoadGLFunction<__glGetTexParameterfv>("glGetTexParameterfv");
                        __GlueGetTexParameteriv = GLFunctionLoader.LoadGLFunction<__glGetTexParameteriv>("glGetTexParameteriv");
                        __GlueHint = GLFunctionLoader.LoadGLFunction<__glHint>("glHint");
                        __GlueIndexMask = GLFunctionLoader.LoadGLFunction<__glIndexMask>("glIndexMask");
                        __GlueIndexPointer = GLFunctionLoader.LoadGLFunction<__glIndexPointer>("glIndexPointer");
                        __GlueIndexd = GLFunctionLoader.LoadGLFunction<__glIndexd>("glIndexd");
                        __GlueIndexdv = GLFunctionLoader.LoadGLFunction<__glIndexdv>("glIndexdv");
                        __GlueIndexf = GLFunctionLoader.LoadGLFunction<__glIndexf>("glIndexf");
                        __GlueIndexfv = GLFunctionLoader.LoadGLFunction<__glIndexfv>("glIndexfv");
                        __GlueIndexi = GLFunctionLoader.LoadGLFunction<__glIndexi>("glIndexi");
                        __GlueIndexiv = GLFunctionLoader.LoadGLFunction<__glIndexiv>("glIndexiv");
                        __GlueIndexs = GLFunctionLoader.LoadGLFunction<__glIndexs>("glIndexs");
                        __GlueIndexsv = GLFunctionLoader.LoadGLFunction<__glIndexsv>("glIndexsv");
                        __GlueIndexub = GLFunctionLoader.LoadGLFunction<__glIndexub>("glIndexub");
                        __GlueIndexubv = GLFunctionLoader.LoadGLFunction<__glIndexubv>("glIndexubv");
                        __GlueInitNames = GLFunctionLoader.LoadGLFunction<__glInitNames>("glInitNames");
                        __GlueInterleavedArrays = GLFunctionLoader.LoadGLFunction<__glInterleavedArrays>("glInterleavedArrays");
                        __GlueIsEnabled = GLFunctionLoader.LoadGLFunction<__glIsEnabled>("glIsEnabled");
                        __GlueIsList = GLFunctionLoader.LoadGLFunction<__glIsList>("glIsList");
                        __GlueIsTexture = GLFunctionLoader.LoadGLFunction<__glIsTexture>("glIsTexture");
                        __GlueLightModelf = GLFunctionLoader.LoadGLFunction<__glLightModelf>("glLightModelf");
                        __GlueLightModelfv = GLFunctionLoader.LoadGLFunction<__glLightModelfv>("glLightModelfv");
                        __GlueLightModeli = GLFunctionLoader.LoadGLFunction<__glLightModeli>("glLightModeli");
                        __GlueLightModeliv = GLFunctionLoader.LoadGLFunction<__glLightModeliv>("glLightModeliv");
                        __GlueLightf = GLFunctionLoader.LoadGLFunction<__glLightf>("glLightf");
                        __GlueLightfv = GLFunctionLoader.LoadGLFunction<__glLightfv>("glLightfv");
                        __GlueLighti = GLFunctionLoader.LoadGLFunction<__glLighti>("glLighti");
                        __GlueLightiv = GLFunctionLoader.LoadGLFunction<__glLightiv>("glLightiv");
                        __GlueLineStipple = GLFunctionLoader.LoadGLFunction<__glLineStipple>("glLineStipple");
                        __GlueLineWidth = GLFunctionLoader.LoadGLFunction<__glLineWidth>("glLineWidth");
                        __GlueListBase = GLFunctionLoader.LoadGLFunction<__glListBase>("glListBase");
                        __GlueLoadIdentity = GLFunctionLoader.LoadGLFunction<__glLoadIdentity>("glLoadIdentity");
                        __GlueLoadMatrixd = GLFunctionLoader.LoadGLFunction<__glLoadMatrixd>("glLoadMatrixd");
                        __GlueLoadMatrixf = GLFunctionLoader.LoadGLFunction<__glLoadMatrixf>("glLoadMatrixf");
                        __GlueLoadName = GLFunctionLoader.LoadGLFunction<__glLoadName>("glLoadName");
                        __GlueLogicOp = GLFunctionLoader.LoadGLFunction<__glLogicOp>("glLogicOp");
                        __GlueMap1d = GLFunctionLoader.LoadGLFunction<__glMap1d>("glMap1d");
                        __GlueMap1f = GLFunctionLoader.LoadGLFunction<__glMap1f>("glMap1f");
                        __GlueMap2d = GLFunctionLoader.LoadGLFunction<__glMap2d>("glMap2d");
                        __GlueMap2f = GLFunctionLoader.LoadGLFunction<__glMap2f>("glMap2f");
                        __GlueMapGrid1d = GLFunctionLoader.LoadGLFunction<__glMapGrid1d>("glMapGrid1d");
                        __GlueMapGrid1f = GLFunctionLoader.LoadGLFunction<__glMapGrid1f>("glMapGrid1f");
                        __GlueMapGrid2d = GLFunctionLoader.LoadGLFunction<__glMapGrid2d>("glMapGrid2d");
                        __GlueMapGrid2f = GLFunctionLoader.LoadGLFunction<__glMapGrid2f>("glMapGrid2f");
                        __GlueMaterialf = GLFunctionLoader.LoadGLFunction<__glMaterialf>("glMaterialf");
                        __GlueMaterialfv = GLFunctionLoader.LoadGLFunction<__glMaterialfv>("glMaterialfv");
                        __GlueMateriali = GLFunctionLoader.LoadGLFunction<__glMateriali>("glMateriali");
                        __GlueMaterialiv = GLFunctionLoader.LoadGLFunction<__glMaterialiv>("glMaterialiv");
                        __GlueMatrixMode = GLFunctionLoader.LoadGLFunction<__glMatrixMode>("glMatrixMode");
                        __GlueMultMatrixd = GLFunctionLoader.LoadGLFunction<__glMultMatrixd>("glMultMatrixd");
                        __GlueMultMatrixf = GLFunctionLoader.LoadGLFunction<__glMultMatrixf>("glMultMatrixf");
                        __GlueNewList = GLFunctionLoader.LoadGLFunction<__glNewList>("glNewList");
                        __GlueNormal3b = GLFunctionLoader.LoadGLFunction<__glNormal3b>("glNormal3b");
                        __GlueNormal3bv = GLFunctionLoader.LoadGLFunction<__glNormal3bv>("glNormal3bv");
                        __GlueNormal3d = GLFunctionLoader.LoadGLFunction<__glNormal3d>("glNormal3d");
                        __GlueNormal3dv = GLFunctionLoader.LoadGLFunction<__glNormal3dv>("glNormal3dv");
                        __GlueNormal3f = GLFunctionLoader.LoadGLFunction<__glNormal3f>("glNormal3f");
                        __GlueNormal3fv = GLFunctionLoader.LoadGLFunction<__glNormal3fv>("glNormal3fv");
                        __GlueNormal3i = GLFunctionLoader.LoadGLFunction<__glNormal3i>("glNormal3i");
                        __GlueNormal3iv = GLFunctionLoader.LoadGLFunction<__glNormal3iv>("glNormal3iv");
                        __GlueNormal3s = GLFunctionLoader.LoadGLFunction<__glNormal3s>("glNormal3s");
                        __GlueNormal3sv = GLFunctionLoader.LoadGLFunction<__glNormal3sv>("glNormal3sv");
                        __GlueNormalPointer = GLFunctionLoader.LoadGLFunction<__glNormalPointer>("glNormalPointer");
                        __GlueOrtho = GLFunctionLoader.LoadGLFunction<__glOrtho>("glOrtho");
                        __GluePassThrough = GLFunctionLoader.LoadGLFunction<__glPassThrough>("glPassThrough");
                        __GluePixelMapfv = GLFunctionLoader.LoadGLFunction<__glPixelMapfv>("glPixelMapfv");
                        __GluePixelMapuiv = GLFunctionLoader.LoadGLFunction<__glPixelMapuiv>("glPixelMapuiv");
                        __GluePixelMapusv = GLFunctionLoader.LoadGLFunction<__glPixelMapusv>("glPixelMapusv");
                        __GluePixelStoref = GLFunctionLoader.LoadGLFunction<__glPixelStoref>("glPixelStoref");
                        __GluePixelStorei = GLFunctionLoader.LoadGLFunction<__glPixelStorei>("glPixelStorei");
                        __GluePixelTransferf = GLFunctionLoader.LoadGLFunction<__glPixelTransferf>("glPixelTransferf");
                        __GluePixelTransferi = GLFunctionLoader.LoadGLFunction<__glPixelTransferi>("glPixelTransferi");
                        __GluePixelZoom = GLFunctionLoader.LoadGLFunction<__glPixelZoom>("glPixelZoom");
                        __GluePointSize = GLFunctionLoader.LoadGLFunction<__glPointSize>("glPointSize");
                        __GluePolygonMode = GLFunctionLoader.LoadGLFunction<__glPolygonMode>("glPolygonMode");
                        __GluePolygonOffset = GLFunctionLoader.LoadGLFunction<__glPolygonOffset>("glPolygonOffset");
                        __GluePolygonStipple = GLFunctionLoader.LoadGLFunction<__glPolygonStipple>("glPolygonStipple");
                        __GluePopAttrib = GLFunctionLoader.LoadGLFunction<__glPopAttrib>("glPopAttrib");
                        __GluePopClientAttrib = GLFunctionLoader.LoadGLFunction<__glPopClientAttrib>("glPopClientAttrib");
                        __GluePopMatrix = GLFunctionLoader.LoadGLFunction<__glPopMatrix>("glPopMatrix");
                        __GluePopName = GLFunctionLoader.LoadGLFunction<__glPopName>("glPopName");
                        __GluePrioritizeTextures = GLFunctionLoader.LoadGLFunction<__glPrioritizeTextures>("glPrioritizeTextures");
                        __GluePushAttrib = GLFunctionLoader.LoadGLFunction<__glPushAttrib>("glPushAttrib");
                        __GluePushClientAttrib = GLFunctionLoader.LoadGLFunction<__glPushClientAttrib>("glPushClientAttrib");
                        __GluePushMatrix = GLFunctionLoader.LoadGLFunction<__glPushMatrix>("glPushMatrix");
                        __GluePushName = GLFunctionLoader.LoadGLFunction<__glPushName>("glPushName");
                        __GlueRasterPos2d = GLFunctionLoader.LoadGLFunction<__glRasterPos2d>("glRasterPos2d");
                        __GlueRasterPos2dv = GLFunctionLoader.LoadGLFunction<__glRasterPos2dv>("glRasterPos2dv");
                        __GlueRasterPos2f = GLFunctionLoader.LoadGLFunction<__glRasterPos2f>("glRasterPos2f");
                        __GlueRasterPos2fv = GLFunctionLoader.LoadGLFunction<__glRasterPos2fv>("glRasterPos2fv");
                        __GlueRasterPos2i = GLFunctionLoader.LoadGLFunction<__glRasterPos2i>("glRasterPos2i");
                        __GlueRasterPos2iv = GLFunctionLoader.LoadGLFunction<__glRasterPos2iv>("glRasterPos2iv");
                        __GlueRasterPos2s = GLFunctionLoader.LoadGLFunction<__glRasterPos2s>("glRasterPos2s");
                        __GlueRasterPos2sv = GLFunctionLoader.LoadGLFunction<__glRasterPos2sv>("glRasterPos2sv");
                        __GlueRasterPos3d = GLFunctionLoader.LoadGLFunction<__glRasterPos3d>("glRasterPos3d");
                        __GlueRasterPos3dv = GLFunctionLoader.LoadGLFunction<__glRasterPos3dv>("glRasterPos3dv");
                        __GlueRasterPos3f = GLFunctionLoader.LoadGLFunction<__glRasterPos3f>("glRasterPos3f");
                        __GlueRasterPos3fv = GLFunctionLoader.LoadGLFunction<__glRasterPos3fv>("glRasterPos3fv");
                        __GlueRasterPos3i = GLFunctionLoader.LoadGLFunction<__glRasterPos3i>("glRasterPos3i");
                        __GlueRasterPos3iv = GLFunctionLoader.LoadGLFunction<__glRasterPos3iv>("glRasterPos3iv");
                        __GlueRasterPos3s = GLFunctionLoader.LoadGLFunction<__glRasterPos3s>("glRasterPos3s");
                        __GlueRasterPos3sv = GLFunctionLoader.LoadGLFunction<__glRasterPos3sv>("glRasterPos3sv");
                        __GlueRasterPos4d = GLFunctionLoader.LoadGLFunction<__glRasterPos4d>("glRasterPos4d");
                        __GlueRasterPos4dv = GLFunctionLoader.LoadGLFunction<__glRasterPos4dv>("glRasterPos4dv");
                        __GlueRasterPos4f = GLFunctionLoader.LoadGLFunction<__glRasterPos4f>("glRasterPos4f");
                        __GlueRasterPos4fv = GLFunctionLoader.LoadGLFunction<__glRasterPos4fv>("glRasterPos4fv");
                        __GlueRasterPos4i = GLFunctionLoader.LoadGLFunction<__glRasterPos4i>("glRasterPos4i");
                        __GlueRasterPos4iv = GLFunctionLoader.LoadGLFunction<__glRasterPos4iv>("glRasterPos4iv");
                        __GlueRasterPos4s = GLFunctionLoader.LoadGLFunction<__glRasterPos4s>("glRasterPos4s");
                        __GlueRasterPos4sv = GLFunctionLoader.LoadGLFunction<__glRasterPos4sv>("glRasterPos4sv");
                        __GlueReadBuffer = GLFunctionLoader.LoadGLFunction<__glReadBuffer>("glReadBuffer");
                        __GlueReadPixels = GLFunctionLoader.LoadGLFunction<__glReadPixels>("glReadPixels");
                        __GlueRectd = GLFunctionLoader.LoadGLFunction<__glRectd>("glRectd");
                        __GlueRectdv = GLFunctionLoader.LoadGLFunction<__glRectdv>("glRectdv");
                        __GlueRectf = GLFunctionLoader.LoadGLFunction<__glRectf>("glRectf");
                        __GlueRectfv = GLFunctionLoader.LoadGLFunction<__glRectfv>("glRectfv");
                        __GlueRecti = GLFunctionLoader.LoadGLFunction<__glRecti>("glRecti");
                        __GlueRectiv = GLFunctionLoader.LoadGLFunction<__glRectiv>("glRectiv");
                        __GlueRects = GLFunctionLoader.LoadGLFunction<__glRects>("glRects");
                        __GlueRectsv = GLFunctionLoader.LoadGLFunction<__glRectsv>("glRectsv");
                        __GlueRenderMode = GLFunctionLoader.LoadGLFunction<__glRenderMode>("glRenderMode");
                        __GlueRotated = GLFunctionLoader.LoadGLFunction<__glRotated>("glRotated");
                        __GlueRotatef = GLFunctionLoader.LoadGLFunction<__glRotatef>("glRotatef");
                        __GlueScaled = GLFunctionLoader.LoadGLFunction<__glScaled>("glScaled");
                        __GlueScalef = GLFunctionLoader.LoadGLFunction<__glScalef>("glScalef");
                        __GlueScissor = GLFunctionLoader.LoadGLFunction<__glScissor>("glScissor");
                        __GlueSelectBuffer = GLFunctionLoader.LoadGLFunction<__glSelectBuffer>("glSelectBuffer");
                        __GlueShadeModel = GLFunctionLoader.LoadGLFunction<__glShadeModel>("glShadeModel");
                        __GlueStencilFunc = GLFunctionLoader.LoadGLFunction<__glStencilFunc>("glStencilFunc");
                        __GlueStencilMask = GLFunctionLoader.LoadGLFunction<__glStencilMask>("glStencilMask");
                        __GlueStencilOp = GLFunctionLoader.LoadGLFunction<__glStencilOp>("glStencilOp");
                        __GlueTexCoord1d = GLFunctionLoader.LoadGLFunction<__glTexCoord1d>("glTexCoord1d");
                        __GlueTexCoord1dv = GLFunctionLoader.LoadGLFunction<__glTexCoord1dv>("glTexCoord1dv");
                        __GlueTexCoord1f = GLFunctionLoader.LoadGLFunction<__glTexCoord1f>("glTexCoord1f");
                        __GlueTexCoord1fv = GLFunctionLoader.LoadGLFunction<__glTexCoord1fv>("glTexCoord1fv");
                        __GlueTexCoord1i = GLFunctionLoader.LoadGLFunction<__glTexCoord1i>("glTexCoord1i");
                        __GlueTexCoord1iv = GLFunctionLoader.LoadGLFunction<__glTexCoord1iv>("glTexCoord1iv");
                        __GlueTexCoord1s = GLFunctionLoader.LoadGLFunction<__glTexCoord1s>("glTexCoord1s");
                        __GlueTexCoord1sv = GLFunctionLoader.LoadGLFunction<__glTexCoord1sv>("glTexCoord1sv");
                        __GlueTexCoord2d = GLFunctionLoader.LoadGLFunction<__glTexCoord2d>("glTexCoord2d");
                        __GlueTexCoord2dv = GLFunctionLoader.LoadGLFunction<__glTexCoord2dv>("glTexCoord2dv");
                        __GlueTexCoord2f = GLFunctionLoader.LoadGLFunction<__glTexCoord2f>("glTexCoord2f");
                        __GlueTexCoord2fv = GLFunctionLoader.LoadGLFunction<__glTexCoord2fv>("glTexCoord2fv");
                        __GlueTexCoord2i = GLFunctionLoader.LoadGLFunction<__glTexCoord2i>("glTexCoord2i");
                        __GlueTexCoord2iv = GLFunctionLoader.LoadGLFunction<__glTexCoord2iv>("glTexCoord2iv");
                        __GlueTexCoord2s = GLFunctionLoader.LoadGLFunction<__glTexCoord2s>("glTexCoord2s");
                        __GlueTexCoord2sv = GLFunctionLoader.LoadGLFunction<__glTexCoord2sv>("glTexCoord2sv");
                        __GlueTexCoord3d = GLFunctionLoader.LoadGLFunction<__glTexCoord3d>("glTexCoord3d");
                        __GlueTexCoord3dv = GLFunctionLoader.LoadGLFunction<__glTexCoord3dv>("glTexCoord3dv");
                        __GlueTexCoord3f = GLFunctionLoader.LoadGLFunction<__glTexCoord3f>("glTexCoord3f");
                        __GlueTexCoord3fv = GLFunctionLoader.LoadGLFunction<__glTexCoord3fv>("glTexCoord3fv");
                        __GlueTexCoord3i = GLFunctionLoader.LoadGLFunction<__glTexCoord3i>("glTexCoord3i");
                        __GlueTexCoord3iv = GLFunctionLoader.LoadGLFunction<__glTexCoord3iv>("glTexCoord3iv");
                        __GlueTexCoord3s = GLFunctionLoader.LoadGLFunction<__glTexCoord3s>("glTexCoord3s");
                        __GlueTexCoord3sv = GLFunctionLoader.LoadGLFunction<__glTexCoord3sv>("glTexCoord3sv");
                        __GlueTexCoord4d = GLFunctionLoader.LoadGLFunction<__glTexCoord4d>("glTexCoord4d");
                        __GlueTexCoord4dv = GLFunctionLoader.LoadGLFunction<__glTexCoord4dv>("glTexCoord4dv");
                        __GlueTexCoord4f = GLFunctionLoader.LoadGLFunction<__glTexCoord4f>("glTexCoord4f");
                        __GlueTexCoord4fv = GLFunctionLoader.LoadGLFunction<__glTexCoord4fv>("glTexCoord4fv");
                        __GlueTexCoord4i = GLFunctionLoader.LoadGLFunction<__glTexCoord4i>("glTexCoord4i");
                        __GlueTexCoord4iv = GLFunctionLoader.LoadGLFunction<__glTexCoord4iv>("glTexCoord4iv");
                        __GlueTexCoord4s = GLFunctionLoader.LoadGLFunction<__glTexCoord4s>("glTexCoord4s");
                        __GlueTexCoord4sv = GLFunctionLoader.LoadGLFunction<__glTexCoord4sv>("glTexCoord4sv");
                        __GlueTexCoordPointer = GLFunctionLoader.LoadGLFunction<__glTexCoordPointer>("glTexCoordPointer");
                        __GlueTexEnvf = GLFunctionLoader.LoadGLFunction<__glTexEnvf>("glTexEnvf");
                        __GlueTexEnvfv = GLFunctionLoader.LoadGLFunction<__glTexEnvfv>("glTexEnvfv");
                        __GlueTexEnvi = GLFunctionLoader.LoadGLFunction<__glTexEnvi>("glTexEnvi");
                        __GlueTexEnviv = GLFunctionLoader.LoadGLFunction<__glTexEnviv>("glTexEnviv");
                        __GlueTexGend = GLFunctionLoader.LoadGLFunction<__glTexGend>("glTexGend");
                        __GlueTexGendv = GLFunctionLoader.LoadGLFunction<__glTexGendv>("glTexGendv");
                        __GlueTexGenf = GLFunctionLoader.LoadGLFunction<__glTexGenf>("glTexGenf");
                        __GlueTexGenfv = GLFunctionLoader.LoadGLFunction<__glTexGenfv>("glTexGenfv");
                        __GlueTexGeni = GLFunctionLoader.LoadGLFunction<__glTexGeni>("glTexGeni");
                        __GlueTexGeniv = GLFunctionLoader.LoadGLFunction<__glTexGeniv>("glTexGeniv");
                        __GlueTexImage1D = GLFunctionLoader.LoadGLFunction<__glTexImage1D>("glTexImage1D");
                        __GlueTexImage2D = GLFunctionLoader.LoadGLFunction<__glTexImage2D>("glTexImage2D");
                        __GlueTexParameterf = GLFunctionLoader.LoadGLFunction<__glTexParameterf>("glTexParameterf");
                        __GlueTexParameterfv = GLFunctionLoader.LoadGLFunction<__glTexParameterfv>("glTexParameterfv");
                        __GlueTexParameteri = GLFunctionLoader.LoadGLFunction<__glTexParameteri>("glTexParameteri");
                        __GlueTexParameteriv = GLFunctionLoader.LoadGLFunction<__glTexParameteriv>("glTexParameteriv");
                        __GlueTexSubImage1D = GLFunctionLoader.LoadGLFunction<__glTexSubImage1D>("glTexSubImage1D");
                        __GlueTexSubImage2D = GLFunctionLoader.LoadGLFunction<__glTexSubImage2D>("glTexSubImage2D");
                        __GlueTranslated = GLFunctionLoader.LoadGLFunction<__glTranslated>("glTranslated");
                        __GlueTranslatef = GLFunctionLoader.LoadGLFunction<__glTranslatef>("glTranslatef");
                        __GlueVertex2d = GLFunctionLoader.LoadGLFunction<__glVertex2d>("glVertex2d");
                        __GlueVertex2dv = GLFunctionLoader.LoadGLFunction<__glVertex2dv>("glVertex2dv");
                        __GlueVertex2f = GLFunctionLoader.LoadGLFunction<__glVertex2f>("glVertex2f");
                        __GlueVertex2fv = GLFunctionLoader.LoadGLFunction<__glVertex2fv>("glVertex2fv");
                        __GlueVertex2i = GLFunctionLoader.LoadGLFunction<__glVertex2i>("glVertex2i");
                        __GlueVertex2iv = GLFunctionLoader.LoadGLFunction<__glVertex2iv>("glVertex2iv");
                        __GlueVertex2s = GLFunctionLoader.LoadGLFunction<__glVertex2s>("glVertex2s");
                        __GlueVertex2sv = GLFunctionLoader.LoadGLFunction<__glVertex2sv>("glVertex2sv");
                        __GlueVertex3d = GLFunctionLoader.LoadGLFunction<__glVertex3d>("glVertex3d");
                        __GlueVertex3dv = GLFunctionLoader.LoadGLFunction<__glVertex3dv>("glVertex3dv");
                        __GlueVertex3f = GLFunctionLoader.LoadGLFunction<__glVertex3f>("glVertex3f");
                        __GlueVertex3fv = GLFunctionLoader.LoadGLFunction<__glVertex3fv>("glVertex3fv");
                        __GlueVertex3i = GLFunctionLoader.LoadGLFunction<__glVertex3i>("glVertex3i");
                        __GlueVertex3iv = GLFunctionLoader.LoadGLFunction<__glVertex3iv>("glVertex3iv");
                        __GlueVertex3s = GLFunctionLoader.LoadGLFunction<__glVertex3s>("glVertex3s");
                        __GlueVertex3sv = GLFunctionLoader.LoadGLFunction<__glVertex3sv>("glVertex3sv");
                        __GlueVertex4d = GLFunctionLoader.LoadGLFunction<__glVertex4d>("glVertex4d");
                        __GlueVertex4dv = GLFunctionLoader.LoadGLFunction<__glVertex4dv>("glVertex4dv");
                        __GlueVertex4f = GLFunctionLoader.LoadGLFunction<__glVertex4f>("glVertex4f");
                        __GlueVertex4fv = GLFunctionLoader.LoadGLFunction<__glVertex4fv>("glVertex4fv");
                        __GlueVertex4i = GLFunctionLoader.LoadGLFunction<__glVertex4i>("glVertex4i");
                        __GlueVertex4iv = GLFunctionLoader.LoadGLFunction<__glVertex4iv>("glVertex4iv");
                        __GlueVertex4s = GLFunctionLoader.LoadGLFunction<__glVertex4s>("glVertex4s");
                        __GlueVertex4sv = GLFunctionLoader.LoadGLFunction<__glVertex4sv>("glVertex4sv");
                        __GlueVertexPointer = GLFunctionLoader.LoadGLFunction<__glVertexPointer>("glVertexPointer");
                        __GlueViewport = GLFunctionLoader.LoadGLFunction<__glViewport>("glViewport");


                        GL_1_1 = true;

#if DEBUG
	Console.WriteLine("Initialized GL_1_1");
#endif
                        break;
                    }
                case glInitHint.GL_VERSION_1_2:
                    {
                        __GlueCopyTexSubImage3D = GLFunctionLoader.LoadGLFunction<__glCopyTexSubImage3D>("glCopyTexSubImage3D");
                        __GlueDrawRangeElements = GLFunctionLoader.LoadGLFunction<__glDrawRangeElements>("glDrawRangeElements");
                        __GlueTexImage3D = GLFunctionLoader.LoadGLFunction<__glTexImage3D>("glTexImage3D");
                        __GlueTexSubImage3D = GLFunctionLoader.LoadGLFunction<__glTexSubImage3D>("glTexSubImage3D");


                        GL_1_2 = true;

#if DEBUG
	Console.WriteLine("Initialized GL_1_2");
#endif
                        break;
                    }
                case glInitHint.GL_VERSION_1_2_1:
                    {


                        GL_1_2_1 = true;

#if DEBUG
	Console.WriteLine("Initialized GL_1_2_1");
#endif
                        break;
                    }
                case glInitHint.GL_VERSION_1_3:
                    {
                        __GlueActiveTexture = GLFunctionLoader.LoadGLFunction<__glActiveTexture>("glActiveTexture");
                        __GlueClientActiveTexture = GLFunctionLoader.LoadGLFunction<__glClientActiveTexture>("glClientActiveTexture");
                        __GlueCompressedTexImage1D = GLFunctionLoader.LoadGLFunction<__glCompressedTexImage1D>("glCompressedTexImage1D");
                        __GlueCompressedTexImage2D = GLFunctionLoader.LoadGLFunction<__glCompressedTexImage2D>("glCompressedTexImage2D");
                        __GlueCompressedTexImage3D = GLFunctionLoader.LoadGLFunction<__glCompressedTexImage3D>("glCompressedTexImage3D");
                        __GlueCompressedTexSubImage1D = GLFunctionLoader.LoadGLFunction<__glCompressedTexSubImage1D>("glCompressedTexSubImage1D");
                        __GlueCompressedTexSubImage2D = GLFunctionLoader.LoadGLFunction<__glCompressedTexSubImage2D>("glCompressedTexSubImage2D");
                        __GlueCompressedTexSubImage3D = GLFunctionLoader.LoadGLFunction<__glCompressedTexSubImage3D>("glCompressedTexSubImage3D");
                        __GlueGetCompressedTexImage = GLFunctionLoader.LoadGLFunction<__glGetCompressedTexImage>("glGetCompressedTexImage");
                        __GlueLoadTransposeMatrixd = GLFunctionLoader.LoadGLFunction<__glLoadTransposeMatrixd>("glLoadTransposeMatrixd");
                        __GlueLoadTransposeMatrixf = GLFunctionLoader.LoadGLFunction<__glLoadTransposeMatrixf>("glLoadTransposeMatrixf");
                        __GlueMultTransposeMatrixd = GLFunctionLoader.LoadGLFunction<__glMultTransposeMatrixd>("glMultTransposeMatrixd");
                        __GlueMultTransposeMatrixf = GLFunctionLoader.LoadGLFunction<__glMultTransposeMatrixf>("glMultTransposeMatrixf");
                        __GlueMultiTexCoord1d = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord1d>("glMultiTexCoord1d");
                        __GlueMultiTexCoord1dv = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord1dv>("glMultiTexCoord1dv");
                        __GlueMultiTexCoord1f = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord1f>("glMultiTexCoord1f");
                        __GlueMultiTexCoord1fv = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord1fv>("glMultiTexCoord1fv");
                        __GlueMultiTexCoord1i = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord1i>("glMultiTexCoord1i");
                        __GlueMultiTexCoord1iv = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord1iv>("glMultiTexCoord1iv");
                        __GlueMultiTexCoord1s = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord1s>("glMultiTexCoord1s");
                        __GlueMultiTexCoord1sv = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord1sv>("glMultiTexCoord1sv");
                        __GlueMultiTexCoord2d = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord2d>("glMultiTexCoord2d");
                        __GlueMultiTexCoord2dv = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord2dv>("glMultiTexCoord2dv");
                        __GlueMultiTexCoord2f = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord2f>("glMultiTexCoord2f");
                        __GlueMultiTexCoord2fv = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord2fv>("glMultiTexCoord2fv");
                        __GlueMultiTexCoord2i = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord2i>("glMultiTexCoord2i");
                        __GlueMultiTexCoord2iv = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord2iv>("glMultiTexCoord2iv");
                        __GlueMultiTexCoord2s = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord2s>("glMultiTexCoord2s");
                        __GlueMultiTexCoord2sv = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord2sv>("glMultiTexCoord2sv");
                        __GlueMultiTexCoord3d = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord3d>("glMultiTexCoord3d");
                        __GlueMultiTexCoord3dv = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord3dv>("glMultiTexCoord3dv");
                        __GlueMultiTexCoord3f = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord3f>("glMultiTexCoord3f");
                        __GlueMultiTexCoord3fv = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord3fv>("glMultiTexCoord3fv");
                        __GlueMultiTexCoord3i = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord3i>("glMultiTexCoord3i");
                        __GlueMultiTexCoord3iv = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord3iv>("glMultiTexCoord3iv");
                        __GlueMultiTexCoord3s = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord3s>("glMultiTexCoord3s");
                        __GlueMultiTexCoord3sv = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord3sv>("glMultiTexCoord3sv");
                        __GlueMultiTexCoord4d = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord4d>("glMultiTexCoord4d");
                        __GlueMultiTexCoord4dv = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord4dv>("glMultiTexCoord4dv");
                        __GlueMultiTexCoord4f = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord4f>("glMultiTexCoord4f");
                        __GlueMultiTexCoord4fv = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord4fv>("glMultiTexCoord4fv");
                        __GlueMultiTexCoord4i = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord4i>("glMultiTexCoord4i");
                        __GlueMultiTexCoord4iv = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord4iv>("glMultiTexCoord4iv");
                        __GlueMultiTexCoord4s = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord4s>("glMultiTexCoord4s");
                        __GlueMultiTexCoord4sv = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord4sv>("glMultiTexCoord4sv");
                        __GlueSampleCoverage = GLFunctionLoader.LoadGLFunction<__glSampleCoverage>("glSampleCoverage");


                        GL_1_3 = true;

#if DEBUG
	Console.WriteLine("Initialized GL_1_3");
#endif
                        break;
                    }
                case glInitHint.GL_VERSION_1_4:
                    {
                        __GlueBlendColor = GLFunctionLoader.LoadGLFunction<__glBlendColor>("glBlendColor");
                        __GlueBlendEquation = GLFunctionLoader.LoadGLFunction<__glBlendEquation>("glBlendEquation");
                        __GlueBlendFuncSeparate = GLFunctionLoader.LoadGLFunction<__glBlendFuncSeparate>("glBlendFuncSeparate");
                        __GlueFogCoordPointer = GLFunctionLoader.LoadGLFunction<__glFogCoordPointer>("glFogCoordPointer");
                        __GlueFogCoordd = GLFunctionLoader.LoadGLFunction<__glFogCoordd>("glFogCoordd");
                        __GlueFogCoorddv = GLFunctionLoader.LoadGLFunction<__glFogCoorddv>("glFogCoorddv");
                        __GlueFogCoordf = GLFunctionLoader.LoadGLFunction<__glFogCoordf>("glFogCoordf");
                        __GlueFogCoordfv = GLFunctionLoader.LoadGLFunction<__glFogCoordfv>("glFogCoordfv");
                        __GlueMultiDrawArrays = GLFunctionLoader.LoadGLFunction<__glMultiDrawArrays>("glMultiDrawArrays");
                        __GlueMultiDrawElements = GLFunctionLoader.LoadGLFunction<__glMultiDrawElements>("glMultiDrawElements");
                        __GluePointParameterf = GLFunctionLoader.LoadGLFunction<__glPointParameterf>("glPointParameterf");
                        __GluePointParameterfv = GLFunctionLoader.LoadGLFunction<__glPointParameterfv>("glPointParameterfv");
                        __GluePointParameteri = GLFunctionLoader.LoadGLFunction<__glPointParameteri>("glPointParameteri");
                        __GluePointParameteriv = GLFunctionLoader.LoadGLFunction<__glPointParameteriv>("glPointParameteriv");
                        __GlueSecondaryColor3b = GLFunctionLoader.LoadGLFunction<__glSecondaryColor3b>("glSecondaryColor3b");
                        __GlueSecondaryColor3bv = GLFunctionLoader.LoadGLFunction<__glSecondaryColor3bv>("glSecondaryColor3bv");
                        __GlueSecondaryColor3d = GLFunctionLoader.LoadGLFunction<__glSecondaryColor3d>("glSecondaryColor3d");
                        __GlueSecondaryColor3dv = GLFunctionLoader.LoadGLFunction<__glSecondaryColor3dv>("glSecondaryColor3dv");
                        __GlueSecondaryColor3f = GLFunctionLoader.LoadGLFunction<__glSecondaryColor3f>("glSecondaryColor3f");
                        __GlueSecondaryColor3fv = GLFunctionLoader.LoadGLFunction<__glSecondaryColor3fv>("glSecondaryColor3fv");
                        __GlueSecondaryColor3i = GLFunctionLoader.LoadGLFunction<__glSecondaryColor3i>("glSecondaryColor3i");
                        __GlueSecondaryColor3iv = GLFunctionLoader.LoadGLFunction<__glSecondaryColor3iv>("glSecondaryColor3iv");
                        __GlueSecondaryColor3s = GLFunctionLoader.LoadGLFunction<__glSecondaryColor3s>("glSecondaryColor3s");
                        __GlueSecondaryColor3sv = GLFunctionLoader.LoadGLFunction<__glSecondaryColor3sv>("glSecondaryColor3sv");
                        __GlueSecondaryColor3ub = GLFunctionLoader.LoadGLFunction<__glSecondaryColor3ub>("glSecondaryColor3ub");
                        __GlueSecondaryColor3ubv = GLFunctionLoader.LoadGLFunction<__glSecondaryColor3ubv>("glSecondaryColor3ubv");
                        __GlueSecondaryColor3ui = GLFunctionLoader.LoadGLFunction<__glSecondaryColor3ui>("glSecondaryColor3ui");
                        __GlueSecondaryColor3uiv = GLFunctionLoader.LoadGLFunction<__glSecondaryColor3uiv>("glSecondaryColor3uiv");
                        __GlueSecondaryColor3us = GLFunctionLoader.LoadGLFunction<__glSecondaryColor3us>("glSecondaryColor3us");
                        __GlueSecondaryColor3usv = GLFunctionLoader.LoadGLFunction<__glSecondaryColor3usv>("glSecondaryColor3usv");
                        __GlueSecondaryColorPointer = GLFunctionLoader.LoadGLFunction<__glSecondaryColorPointer>("glSecondaryColorPointer");
                        __GlueWindowPos2d = GLFunctionLoader.LoadGLFunction<__glWindowPos2d>("glWindowPos2d");
                        __GlueWindowPos2dv = GLFunctionLoader.LoadGLFunction<__glWindowPos2dv>("glWindowPos2dv");
                        __GlueWindowPos2f = GLFunctionLoader.LoadGLFunction<__glWindowPos2f>("glWindowPos2f");
                        __GlueWindowPos2fv = GLFunctionLoader.LoadGLFunction<__glWindowPos2fv>("glWindowPos2fv");
                        __GlueWindowPos2i = GLFunctionLoader.LoadGLFunction<__glWindowPos2i>("glWindowPos2i");
                        __GlueWindowPos2iv = GLFunctionLoader.LoadGLFunction<__glWindowPos2iv>("glWindowPos2iv");
                        __GlueWindowPos2s = GLFunctionLoader.LoadGLFunction<__glWindowPos2s>("glWindowPos2s");
                        __GlueWindowPos2sv = GLFunctionLoader.LoadGLFunction<__glWindowPos2sv>("glWindowPos2sv");
                        __GlueWindowPos3d = GLFunctionLoader.LoadGLFunction<__glWindowPos3d>("glWindowPos3d");
                        __GlueWindowPos3dv = GLFunctionLoader.LoadGLFunction<__glWindowPos3dv>("glWindowPos3dv");
                        __GlueWindowPos3f = GLFunctionLoader.LoadGLFunction<__glWindowPos3f>("glWindowPos3f");
                        __GlueWindowPos3fv = GLFunctionLoader.LoadGLFunction<__glWindowPos3fv>("glWindowPos3fv");
                        __GlueWindowPos3i = GLFunctionLoader.LoadGLFunction<__glWindowPos3i>("glWindowPos3i");
                        __GlueWindowPos3iv = GLFunctionLoader.LoadGLFunction<__glWindowPos3iv>("glWindowPos3iv");
                        __GlueWindowPos3s = GLFunctionLoader.LoadGLFunction<__glWindowPos3s>("glWindowPos3s");
                        __GlueWindowPos3sv = GLFunctionLoader.LoadGLFunction<__glWindowPos3sv>("glWindowPos3sv");


                        GL_1_4 = true;

#if DEBUG
	Console.WriteLine("Initialized GL_1_4");
#endif
                        break;
                    }
                case glInitHint.GL_VERSION_1_5:
                    {
                        __GlueBeginQuery = GLFunctionLoader.LoadGLFunction<__glBeginQuery>("glBeginQuery");
                        __GlueBindBuffer = GLFunctionLoader.LoadGLFunction<__glBindBuffer>("glBindBuffer");
                        __GlueBufferData = GLFunctionLoader.LoadGLFunction<__glBufferData>("glBufferData");
                        __GlueBufferSubData = GLFunctionLoader.LoadGLFunction<__glBufferSubData>("glBufferSubData");
                        __GlueDeleteBuffers = GLFunctionLoader.LoadGLFunction<__glDeleteBuffers>("glDeleteBuffers");
                        __GlueDeleteQueries = GLFunctionLoader.LoadGLFunction<__glDeleteQueries>("glDeleteQueries");
                        __GlueEndQuery = GLFunctionLoader.LoadGLFunction<__glEndQuery>("glEndQuery");
                        __GlueGenBuffers = GLFunctionLoader.LoadGLFunction<__glGenBuffers>("glGenBuffers");
                        __GlueGenQueries = GLFunctionLoader.LoadGLFunction<__glGenQueries>("glGenQueries");
                        __GlueGetBufferParameteriv = GLFunctionLoader.LoadGLFunction<__glGetBufferParameteriv>("glGetBufferParameteriv");
                        __GlueGetBufferPointerv = GLFunctionLoader.LoadGLFunction<__glGetBufferPointerv>("glGetBufferPointerv");
                        __GlueGetBufferSubData = GLFunctionLoader.LoadGLFunction<__glGetBufferSubData>("glGetBufferSubData");
                        __GlueGetQueryObjectiv = GLFunctionLoader.LoadGLFunction<__glGetQueryObjectiv>("glGetQueryObjectiv");
                        __GlueGetQueryObjectuiv = GLFunctionLoader.LoadGLFunction<__glGetQueryObjectuiv>("glGetQueryObjectuiv");
                        __GlueGetQueryiv = GLFunctionLoader.LoadGLFunction<__glGetQueryiv>("glGetQueryiv");
                        __GlueIsBuffer = GLFunctionLoader.LoadGLFunction<__glIsBuffer>("glIsBuffer");
                        __GlueIsQuery = GLFunctionLoader.LoadGLFunction<__glIsQuery>("glIsQuery");
                        __GlueMapBuffer = GLFunctionLoader.LoadGLFunction<__glMapBuffer>("glMapBuffer");
                        __GlueUnmapBuffer = GLFunctionLoader.LoadGLFunction<__glUnmapBuffer>("glUnmapBuffer");


                        GL_1_5 = true;

#if DEBUG
	Console.WriteLine("Initialized GL_1_5");
#endif
                        break;
                    }
                case glInitHint.GL_VERSION_2_0:
                    {
                        __GlueAttachShader = GLFunctionLoader.LoadGLFunction<__glAttachShader>("glAttachShader");
                        __GlueBindAttribLocation = GLFunctionLoader.LoadGLFunction<__glBindAttribLocation>("glBindAttribLocation");
                        __GlueBlendEquationSeparate = GLFunctionLoader.LoadGLFunction<__glBlendEquationSeparate>("glBlendEquationSeparate");
                        __GlueCompileShader = GLFunctionLoader.LoadGLFunction<__glCompileShader>("glCompileShader");
                        __GlueCreateProgram = GLFunctionLoader.LoadGLFunction<__glCreateProgram>("glCreateProgram");
                        __GlueCreateShader = GLFunctionLoader.LoadGLFunction<__glCreateShader>("glCreateShader");
                        __GlueDeleteProgram = GLFunctionLoader.LoadGLFunction<__glDeleteProgram>("glDeleteProgram");
                        __GlueDeleteShader = GLFunctionLoader.LoadGLFunction<__glDeleteShader>("glDeleteShader");
                        __GlueDetachShader = GLFunctionLoader.LoadGLFunction<__glDetachShader>("glDetachShader");
                        __GlueDisableVertexAttribArray = GLFunctionLoader.LoadGLFunction<__glDisableVertexAttribArray>("glDisableVertexAttribArray");
                        __GlueDrawBuffers = GLFunctionLoader.LoadGLFunction<__glDrawBuffers>("glDrawBuffers");
                        __GlueEnableVertexAttribArray = GLFunctionLoader.LoadGLFunction<__glEnableVertexAttribArray>("glEnableVertexAttribArray");
                        __GlueGetActiveAttrib = GLFunctionLoader.LoadGLFunction<__glGetActiveAttrib>("glGetActiveAttrib");
                        __GlueGetActiveUniform = GLFunctionLoader.LoadGLFunction<__glGetActiveUniform>("glGetActiveUniform");
                        __GlueGetAttachedShaders = GLFunctionLoader.LoadGLFunction<__glGetAttachedShaders>("glGetAttachedShaders");
                        __GlueGetAttribLocation = GLFunctionLoader.LoadGLFunction<__glGetAttribLocation>("glGetAttribLocation");
                        __GlueGetProgramInfoLog = GLFunctionLoader.LoadGLFunction<__glGetProgramInfoLog>("glGetProgramInfoLog");
                        __GlueGetProgramiv = GLFunctionLoader.LoadGLFunction<__glGetProgramiv>("glGetProgramiv");
                        __GlueGetShaderInfoLog = GLFunctionLoader.LoadGLFunction<__glGetShaderInfoLog>("glGetShaderInfoLog");
                        __GlueGetShaderSource = GLFunctionLoader.LoadGLFunction<__glGetShaderSource>("glGetShaderSource");
                        __GlueGetShaderiv = GLFunctionLoader.LoadGLFunction<__glGetShaderiv>("glGetShaderiv");
                        __GlueGetUniformLocation = GLFunctionLoader.LoadGLFunction<__glGetUniformLocation>("glGetUniformLocation");
                        __GlueGetUniformfv = GLFunctionLoader.LoadGLFunction<__glGetUniformfv>("glGetUniformfv");
                        __GlueGetUniformiv = GLFunctionLoader.LoadGLFunction<__glGetUniformiv>("glGetUniformiv");
                        __GlueGetVertexAttribPointerv = GLFunctionLoader.LoadGLFunction<__glGetVertexAttribPointerv>("glGetVertexAttribPointerv");
                        __GlueGetVertexAttribdv = GLFunctionLoader.LoadGLFunction<__glGetVertexAttribdv>("glGetVertexAttribdv");
                        __GlueGetVertexAttribfv = GLFunctionLoader.LoadGLFunction<__glGetVertexAttribfv>("glGetVertexAttribfv");
                        __GlueGetVertexAttribiv = GLFunctionLoader.LoadGLFunction<__glGetVertexAttribiv>("glGetVertexAttribiv");
                        __GlueIsProgram = GLFunctionLoader.LoadGLFunction<__glIsProgram>("glIsProgram");
                        __GlueIsShader = GLFunctionLoader.LoadGLFunction<__glIsShader>("glIsShader");
                        __GlueLinkProgram = GLFunctionLoader.LoadGLFunction<__glLinkProgram>("glLinkProgram");
                        __GlueShaderSource = GLFunctionLoader.LoadGLFunction<__glShaderSource>("glShaderSource");
                        __GlueStencilFuncSeparate = GLFunctionLoader.LoadGLFunction<__glStencilFuncSeparate>("glStencilFuncSeparate");
                        __GlueStencilMaskSeparate = GLFunctionLoader.LoadGLFunction<__glStencilMaskSeparate>("glStencilMaskSeparate");
                        __GlueStencilOpSeparate = GLFunctionLoader.LoadGLFunction<__glStencilOpSeparate>("glStencilOpSeparate");
                        __GlueUniform1f = GLFunctionLoader.LoadGLFunction<__glUniform1f>("glUniform1f");
                        __GlueUniform1fv = GLFunctionLoader.LoadGLFunction<__glUniform1fv>("glUniform1fv");
                        __GlueUniform1i = GLFunctionLoader.LoadGLFunction<__glUniform1i>("glUniform1i");
                        __GlueUniform1iv = GLFunctionLoader.LoadGLFunction<__glUniform1iv>("glUniform1iv");
                        __GlueUniform2f = GLFunctionLoader.LoadGLFunction<__glUniform2f>("glUniform2f");
                        __GlueUniform2fv = GLFunctionLoader.LoadGLFunction<__glUniform2fv>("glUniform2fv");
                        __GlueUniform2i = GLFunctionLoader.LoadGLFunction<__glUniform2i>("glUniform2i");
                        __GlueUniform2iv = GLFunctionLoader.LoadGLFunction<__glUniform2iv>("glUniform2iv");
                        __GlueUniform3f = GLFunctionLoader.LoadGLFunction<__glUniform3f>("glUniform3f");
                        __GlueUniform3fv = GLFunctionLoader.LoadGLFunction<__glUniform3fv>("glUniform3fv");
                        __GlueUniform3i = GLFunctionLoader.LoadGLFunction<__glUniform3i>("glUniform3i");
                        __GlueUniform3iv = GLFunctionLoader.LoadGLFunction<__glUniform3iv>("glUniform3iv");
                        __GlueUniform4f = GLFunctionLoader.LoadGLFunction<__glUniform4f>("glUniform4f");
                        __GlueUniform4fv = GLFunctionLoader.LoadGLFunction<__glUniform4fv>("glUniform4fv");
                        __GlueUniform4i = GLFunctionLoader.LoadGLFunction<__glUniform4i>("glUniform4i");
                        __GlueUniform4iv = GLFunctionLoader.LoadGLFunction<__glUniform4iv>("glUniform4iv");
                        __GlueUniformMatrix2fv = GLFunctionLoader.LoadGLFunction<__glUniformMatrix2fv>("glUniformMatrix2fv");
                        __GlueUniformMatrix3fv = GLFunctionLoader.LoadGLFunction<__glUniformMatrix3fv>("glUniformMatrix3fv");
                        __GlueUniformMatrix4fv = GLFunctionLoader.LoadGLFunction<__glUniformMatrix4fv>("glUniformMatrix4fv");
                        __GlueUseProgram = GLFunctionLoader.LoadGLFunction<__glUseProgram>("glUseProgram");
                        __GlueValidateProgram = GLFunctionLoader.LoadGLFunction<__glValidateProgram>("glValidateProgram");
                        __GlueVertexAttrib1d = GLFunctionLoader.LoadGLFunction<__glVertexAttrib1d>("glVertexAttrib1d");
                        __GlueVertexAttrib1dv = GLFunctionLoader.LoadGLFunction<__glVertexAttrib1dv>("glVertexAttrib1dv");
                        __GlueVertexAttrib1f = GLFunctionLoader.LoadGLFunction<__glVertexAttrib1f>("glVertexAttrib1f");
                        __GlueVertexAttrib1fv = GLFunctionLoader.LoadGLFunction<__glVertexAttrib1fv>("glVertexAttrib1fv");
                        __GlueVertexAttrib1s = GLFunctionLoader.LoadGLFunction<__glVertexAttrib1s>("glVertexAttrib1s");
                        __GlueVertexAttrib1sv = GLFunctionLoader.LoadGLFunction<__glVertexAttrib1sv>("glVertexAttrib1sv");
                        __GlueVertexAttrib2d = GLFunctionLoader.LoadGLFunction<__glVertexAttrib2d>("glVertexAttrib2d");
                        __GlueVertexAttrib2dv = GLFunctionLoader.LoadGLFunction<__glVertexAttrib2dv>("glVertexAttrib2dv");
                        __GlueVertexAttrib2f = GLFunctionLoader.LoadGLFunction<__glVertexAttrib2f>("glVertexAttrib2f");
                        __GlueVertexAttrib2fv = GLFunctionLoader.LoadGLFunction<__glVertexAttrib2fv>("glVertexAttrib2fv");
                        __GlueVertexAttrib2s = GLFunctionLoader.LoadGLFunction<__glVertexAttrib2s>("glVertexAttrib2s");
                        __GlueVertexAttrib2sv = GLFunctionLoader.LoadGLFunction<__glVertexAttrib2sv>("glVertexAttrib2sv");
                        __GlueVertexAttrib3d = GLFunctionLoader.LoadGLFunction<__glVertexAttrib3d>("glVertexAttrib3d");
                        __GlueVertexAttrib3dv = GLFunctionLoader.LoadGLFunction<__glVertexAttrib3dv>("glVertexAttrib3dv");
                        __GlueVertexAttrib3f = GLFunctionLoader.LoadGLFunction<__glVertexAttrib3f>("glVertexAttrib3f");
                        __GlueVertexAttrib3fv = GLFunctionLoader.LoadGLFunction<__glVertexAttrib3fv>("glVertexAttrib3fv");
                        __GlueVertexAttrib3s = GLFunctionLoader.LoadGLFunction<__glVertexAttrib3s>("glVertexAttrib3s");
                        __GlueVertexAttrib3sv = GLFunctionLoader.LoadGLFunction<__glVertexAttrib3sv>("glVertexAttrib3sv");
                        __GlueVertexAttrib4Nbv = GLFunctionLoader.LoadGLFunction<__glVertexAttrib4Nbv>("glVertexAttrib4Nbv");
                        __GlueVertexAttrib4Niv = GLFunctionLoader.LoadGLFunction<__glVertexAttrib4Niv>("glVertexAttrib4Niv");
                        __GlueVertexAttrib4Nsv = GLFunctionLoader.LoadGLFunction<__glVertexAttrib4Nsv>("glVertexAttrib4Nsv");
                        __GlueVertexAttrib4Nub = GLFunctionLoader.LoadGLFunction<__glVertexAttrib4Nub>("glVertexAttrib4Nub");
                        __GlueVertexAttrib4Nubv = GLFunctionLoader.LoadGLFunction<__glVertexAttrib4Nubv>("glVertexAttrib4Nubv");
                        __GlueVertexAttrib4Nuiv = GLFunctionLoader.LoadGLFunction<__glVertexAttrib4Nuiv>("glVertexAttrib4Nuiv");
                        __GlueVertexAttrib4Nusv = GLFunctionLoader.LoadGLFunction<__glVertexAttrib4Nusv>("glVertexAttrib4Nusv");
                        __GlueVertexAttrib4bv = GLFunctionLoader.LoadGLFunction<__glVertexAttrib4bv>("glVertexAttrib4bv");
                        __GlueVertexAttrib4d = GLFunctionLoader.LoadGLFunction<__glVertexAttrib4d>("glVertexAttrib4d");
                        __GlueVertexAttrib4dv = GLFunctionLoader.LoadGLFunction<__glVertexAttrib4dv>("glVertexAttrib4dv");
                        __GlueVertexAttrib4f = GLFunctionLoader.LoadGLFunction<__glVertexAttrib4f>("glVertexAttrib4f");
                        __GlueVertexAttrib4fv = GLFunctionLoader.LoadGLFunction<__glVertexAttrib4fv>("glVertexAttrib4fv");
                        __GlueVertexAttrib4iv = GLFunctionLoader.LoadGLFunction<__glVertexAttrib4iv>("glVertexAttrib4iv");
                        __GlueVertexAttrib4s = GLFunctionLoader.LoadGLFunction<__glVertexAttrib4s>("glVertexAttrib4s");
                        __GlueVertexAttrib4sv = GLFunctionLoader.LoadGLFunction<__glVertexAttrib4sv>("glVertexAttrib4sv");
                        __GlueVertexAttrib4ubv = GLFunctionLoader.LoadGLFunction<__glVertexAttrib4ubv>("glVertexAttrib4ubv");
                        __GlueVertexAttrib4uiv = GLFunctionLoader.LoadGLFunction<__glVertexAttrib4uiv>("glVertexAttrib4uiv");
                        __GlueVertexAttrib4usv = GLFunctionLoader.LoadGLFunction<__glVertexAttrib4usv>("glVertexAttrib4usv");
                        __GlueVertexAttribPointer = GLFunctionLoader.LoadGLFunction<__glVertexAttribPointer>("glVertexAttribPointer");


                        GL_2_0 = true;

#if DEBUG
	Console.WriteLine("Initialized GL_2_0");
#endif
                        break;
                    }
                case glInitHint.GL_VERSION_2_1:
                    {
                        __GlueUniformMatrix2x3fv = GLFunctionLoader.LoadGLFunction<__glUniformMatrix2x3fv>("glUniformMatrix2x3fv");
                        __GlueUniformMatrix2x4fv = GLFunctionLoader.LoadGLFunction<__glUniformMatrix2x4fv>("glUniformMatrix2x4fv");
                        __GlueUniformMatrix3x2fv = GLFunctionLoader.LoadGLFunction<__glUniformMatrix3x2fv>("glUniformMatrix3x2fv");
                        __GlueUniformMatrix3x4fv = GLFunctionLoader.LoadGLFunction<__glUniformMatrix3x4fv>("glUniformMatrix3x4fv");
                        __GlueUniformMatrix4x2fv = GLFunctionLoader.LoadGLFunction<__glUniformMatrix4x2fv>("glUniformMatrix4x2fv");
                        __GlueUniformMatrix4x3fv = GLFunctionLoader.LoadGLFunction<__glUniformMatrix4x3fv>("glUniformMatrix4x3fv");


                        GL_2_1 = true;

#if DEBUG
	Console.WriteLine("Initialized GL_2_1");
#endif
                        break;
                    }
                case glInitHint.GL_VERSION_3_0:
                    {
                        __GlueBeginConditionalRender = GLFunctionLoader.LoadGLFunction<__glBeginConditionalRender>("glBeginConditionalRender");
                        __GlueBeginTransformFeedback = GLFunctionLoader.LoadGLFunction<__glBeginTransformFeedback>("glBeginTransformFeedback");
                        __GlueBindFragDataLocation = GLFunctionLoader.LoadGLFunction<__glBindFragDataLocation>("glBindFragDataLocation");
                        __GlueClampColor = GLFunctionLoader.LoadGLFunction<__glClampColor>("glClampColor");
                        __GlueClearBufferfi = GLFunctionLoader.LoadGLFunction<__glClearBufferfi>("glClearBufferfi");
                        __GlueClearBufferfv = GLFunctionLoader.LoadGLFunction<__glClearBufferfv>("glClearBufferfv");
                        __GlueClearBufferiv = GLFunctionLoader.LoadGLFunction<__glClearBufferiv>("glClearBufferiv");
                        __GlueClearBufferuiv = GLFunctionLoader.LoadGLFunction<__glClearBufferuiv>("glClearBufferuiv");
                        __GlueColorMaski = GLFunctionLoader.LoadGLFunction<__glColorMaski>("glColorMaski");
                        __GlueDisablei = GLFunctionLoader.LoadGLFunction<__glDisablei>("glDisablei");
                        __GlueEnablei = GLFunctionLoader.LoadGLFunction<__glEnablei>("glEnablei");
                        __GlueEndConditionalRender = GLFunctionLoader.LoadGLFunction<__glEndConditionalRender>("glEndConditionalRender");
                        __GlueEndTransformFeedback = GLFunctionLoader.LoadGLFunction<__glEndTransformFeedback>("glEndTransformFeedback");
                        __GlueGetBooleani_v = GLFunctionLoader.LoadGLFunction<__glGetBooleani_v>("glGetBooleani_v");
                        __GlueGetFragDataLocation = GLFunctionLoader.LoadGLFunction<__glGetFragDataLocation>("glGetFragDataLocation");
                        __GlueGetStringi = GLFunctionLoader.LoadGLFunction<__glGetStringi>("glGetStringi");
                        __GlueGetTexParameterIiv = GLFunctionLoader.LoadGLFunction<__glGetTexParameterIiv>("glGetTexParameterIiv");
                        __GlueGetTexParameterIuiv = GLFunctionLoader.LoadGLFunction<__glGetTexParameterIuiv>("glGetTexParameterIuiv");
                        __GlueGetTransformFeedbackVarying = GLFunctionLoader.LoadGLFunction<__glGetTransformFeedbackVarying>("glGetTransformFeedbackVarying");
                        __GlueGetUniformuiv = GLFunctionLoader.LoadGLFunction<__glGetUniformuiv>("glGetUniformuiv");
                        __GlueGetVertexAttribIiv = GLFunctionLoader.LoadGLFunction<__glGetVertexAttribIiv>("glGetVertexAttribIiv");
                        __GlueGetVertexAttribIuiv = GLFunctionLoader.LoadGLFunction<__glGetVertexAttribIuiv>("glGetVertexAttribIuiv");
                        __GlueIsEnabledi = GLFunctionLoader.LoadGLFunction<__glIsEnabledi>("glIsEnabledi");
                        __GlueTexParameterIiv = GLFunctionLoader.LoadGLFunction<__glTexParameterIiv>("glTexParameterIiv");
                        __GlueTexParameterIuiv = GLFunctionLoader.LoadGLFunction<__glTexParameterIuiv>("glTexParameterIuiv");
                        __GlueTransformFeedbackVaryings = GLFunctionLoader.LoadGLFunction<__glTransformFeedbackVaryings>("glTransformFeedbackVaryings");
                        __GlueUniform1ui = GLFunctionLoader.LoadGLFunction<__glUniform1ui>("glUniform1ui");
                        __GlueUniform1uiv = GLFunctionLoader.LoadGLFunction<__glUniform1uiv>("glUniform1uiv");
                        __GlueUniform2ui = GLFunctionLoader.LoadGLFunction<__glUniform2ui>("glUniform2ui");
                        __GlueUniform2uiv = GLFunctionLoader.LoadGLFunction<__glUniform2uiv>("glUniform2uiv");
                        __GlueUniform3ui = GLFunctionLoader.LoadGLFunction<__glUniform3ui>("glUniform3ui");
                        __GlueUniform3uiv = GLFunctionLoader.LoadGLFunction<__glUniform3uiv>("glUniform3uiv");
                        __GlueUniform4ui = GLFunctionLoader.LoadGLFunction<__glUniform4ui>("glUniform4ui");
                        __GlueUniform4uiv = GLFunctionLoader.LoadGLFunction<__glUniform4uiv>("glUniform4uiv");
                        __GlueVertexAttribI1i = GLFunctionLoader.LoadGLFunction<__glVertexAttribI1i>("glVertexAttribI1i");
                        __GlueVertexAttribI1iv = GLFunctionLoader.LoadGLFunction<__glVertexAttribI1iv>("glVertexAttribI1iv");
                        __GlueVertexAttribI1ui = GLFunctionLoader.LoadGLFunction<__glVertexAttribI1ui>("glVertexAttribI1ui");
                        __GlueVertexAttribI1uiv = GLFunctionLoader.LoadGLFunction<__glVertexAttribI1uiv>("glVertexAttribI1uiv");
                        __GlueVertexAttribI2i = GLFunctionLoader.LoadGLFunction<__glVertexAttribI2i>("glVertexAttribI2i");
                        __GlueVertexAttribI2iv = GLFunctionLoader.LoadGLFunction<__glVertexAttribI2iv>("glVertexAttribI2iv");
                        __GlueVertexAttribI2ui = GLFunctionLoader.LoadGLFunction<__glVertexAttribI2ui>("glVertexAttribI2ui");
                        __GlueVertexAttribI2uiv = GLFunctionLoader.LoadGLFunction<__glVertexAttribI2uiv>("glVertexAttribI2uiv");
                        __GlueVertexAttribI3i = GLFunctionLoader.LoadGLFunction<__glVertexAttribI3i>("glVertexAttribI3i");
                        __GlueVertexAttribI3iv = GLFunctionLoader.LoadGLFunction<__glVertexAttribI3iv>("glVertexAttribI3iv");
                        __GlueVertexAttribI3ui = GLFunctionLoader.LoadGLFunction<__glVertexAttribI3ui>("glVertexAttribI3ui");
                        __GlueVertexAttribI3uiv = GLFunctionLoader.LoadGLFunction<__glVertexAttribI3uiv>("glVertexAttribI3uiv");
                        __GlueVertexAttribI4bv = GLFunctionLoader.LoadGLFunction<__glVertexAttribI4bv>("glVertexAttribI4bv");
                        __GlueVertexAttribI4i = GLFunctionLoader.LoadGLFunction<__glVertexAttribI4i>("glVertexAttribI4i");
                        __GlueVertexAttribI4iv = GLFunctionLoader.LoadGLFunction<__glVertexAttribI4iv>("glVertexAttribI4iv");
                        __GlueVertexAttribI4sv = GLFunctionLoader.LoadGLFunction<__glVertexAttribI4sv>("glVertexAttribI4sv");
                        __GlueVertexAttribI4ubv = GLFunctionLoader.LoadGLFunction<__glVertexAttribI4ubv>("glVertexAttribI4ubv");
                        __GlueVertexAttribI4ui = GLFunctionLoader.LoadGLFunction<__glVertexAttribI4ui>("glVertexAttribI4ui");
                        __GlueVertexAttribI4uiv = GLFunctionLoader.LoadGLFunction<__glVertexAttribI4uiv>("glVertexAttribI4uiv");
                        __GlueVertexAttribI4usv = GLFunctionLoader.LoadGLFunction<__glVertexAttribI4usv>("glVertexAttribI4usv");
                        __GlueVertexAttribIPointer = GLFunctionLoader.LoadGLFunction<__glVertexAttribIPointer>("glVertexAttribIPointer");


                        GL_3_0 = true;

#if DEBUG
	Console.WriteLine("Initialized GL_3_0");
#endif
                        break;
                    }
                case glInitHint.GL_VERSION_3_1:
                    {
                        __GlueDrawArraysInstanced = GLFunctionLoader.LoadGLFunction<__glDrawArraysInstanced>("glDrawArraysInstanced");
                        __GlueDrawElementsInstanced = GLFunctionLoader.LoadGLFunction<__glDrawElementsInstanced>("glDrawElementsInstanced");
                        __GluePrimitiveRestartIndex = GLFunctionLoader.LoadGLFunction<__glPrimitiveRestartIndex>("glPrimitiveRestartIndex");
                        __GlueTexBuffer = GLFunctionLoader.LoadGLFunction<__glTexBuffer>("glTexBuffer");


                        GL_3_1 = true;

#if DEBUG
	Console.WriteLine("Initialized GL_3_1");
#endif
                        break;
                    }
                case glInitHint.GL_VERSION_3_2:
                    {
                        __GlueFramebufferTexture = GLFunctionLoader.LoadGLFunction<__glFramebufferTexture>("glFramebufferTexture");
                        __GlueGetBufferParameteri64v = GLFunctionLoader.LoadGLFunction<__glGetBufferParameteri64v>("glGetBufferParameteri64v");
                        __GlueGetInteger64i_v = GLFunctionLoader.LoadGLFunction<__glGetInteger64i_v>("glGetInteger64i_v");


                        GL_3_2 = true;

#if DEBUG
	Console.WriteLine("Initialized GL_3_2");
#endif
                        break;
                    }
                case glInitHint.GL_VERSION_3_3:
                    {
                        __GlueVertexAttribDivisor = GLFunctionLoader.LoadGLFunction<__glVertexAttribDivisor>("glVertexAttribDivisor");


                        GL_3_3 = true;

#if DEBUG
	Console.WriteLine("Initialized GL_3_3");
#endif
                        break;
                    }
                case glInitHint.GL_VERSION_4_0:
                    {
                        __GlueBlendEquationSeparatei = GLFunctionLoader.LoadGLFunction<__glBlendEquationSeparatei>("glBlendEquationSeparatei");
                        __GlueBlendEquationi = GLFunctionLoader.LoadGLFunction<__glBlendEquationi>("glBlendEquationi");
                        __GlueBlendFuncSeparatei = GLFunctionLoader.LoadGLFunction<__glBlendFuncSeparatei>("glBlendFuncSeparatei");
                        __GlueBlendFunci = GLFunctionLoader.LoadGLFunction<__glBlendFunci>("glBlendFunci");
                        __GlueMinSampleShading = GLFunctionLoader.LoadGLFunction<__glMinSampleShading>("glMinSampleShading");


                        GL_4_0 = true;

#if DEBUG
	Console.WriteLine("Initialized GL_4_0");
#endif
                        break;
                    }
                case glInitHint.GL_VERSION_4_1:
                    {


                        GL_4_1 = true;

#if DEBUG
	Console.WriteLine("Initialized GL_4_1");
#endif
                        break;
                    }
                case glInitHint.GL_VERSION_4_2:
                    {


                        GL_4_2 = true;

#if DEBUG
	Console.WriteLine("Initialized GL_4_2");
#endif
                        break;
                    }
                case glInitHint.GL_VERSION_4_3:
                    {


                        GL_4_3 = true;

#if DEBUG
	Console.WriteLine("Initialized GL_4_3");
#endif
                        break;
                    }
                case glInitHint.GL_VERSION_4_4:
                    {


                        GL_4_4 = true;

#if DEBUG
	Console.WriteLine("Initialized GL_4_4");
#endif
                        break;
                    }
                case glInitHint.GL_VERSION_4_5:
                    {
                        __GlueGetGraphicsResetStatus = GLFunctionLoader.LoadGLFunction<__glGetGraphicsResetStatus>("glGetGraphicsResetStatus");
                        __GlueGetnCompressedTexImage = GLFunctionLoader.LoadGLFunction<__glGetnCompressedTexImage>("glGetnCompressedTexImage");
                        __GlueGetnTexImage = GLFunctionLoader.LoadGLFunction<__glGetnTexImage>("glGetnTexImage");
                        __GlueGetnUniformdv = GLFunctionLoader.LoadGLFunction<__glGetnUniformdv>("glGetnUniformdv");


                        GL_4_5 = true;

#if DEBUG
	Console.WriteLine("Initialized GL_4_5");
#endif
                        break;
                    }
                case glInitHint.GL_VERSION_4_6:
                    {
                        __GlueMultiDrawArraysIndirectCount = GLFunctionLoader.LoadGLFunction<__glMultiDrawArraysIndirectCount>("glMultiDrawArraysIndirectCount");
                        __GlueMultiDrawElementsIndirectCount = GLFunctionLoader.LoadGLFunction<__glMultiDrawElementsIndirectCount>("glMultiDrawElementsIndirectCount");
                        __GlueSpecializeShader = GLFunctionLoader.LoadGLFunction<__glSpecializeShader>("glSpecializeShader");


                        GL_4_6 = true;

#if DEBUG
	Console.WriteLine("Initialized GL_4_6");
#endif
                        break;
                    }
            }

        }

    }
}
