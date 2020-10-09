#ifndef SkyboxH
#define SkyboxH

#include "stdafx.h"
#include "polygon.h"

class Skybox
{
public:
	Skybox(void);
	~Skybox(void);

	void SetWorld(POLYGON *pPolygon);
	void RenderBackground(void (* View)(int X, int Y), int x_X, int y_Y, GLfloat BackgroundColor1[3], GLfloat BackgroundColor2[3]);
	void RenderCubemap(CAMERA *cam, Texture* CubemapTexture);
};
#endif

