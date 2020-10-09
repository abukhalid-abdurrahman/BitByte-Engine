//////////////////////////////////
//Разработчик: Faridun Berdiev
//****************************
//Имя Файл: Graphics.cpp
//******************
//Версия: v0.1.8
//************
//Файл отвечающий за графику и прорисовку
//*****************************************
//////////////////////////////////

#include "stdafx.h"
#include "Graphics.h"
#include "PlayMode.h"

Lighting Light;
Skybox Sky;

Graphics::Graphics(void)
{
}

Graphics::~Graphics(void)
{
}


void Graphics::Init(bool lEnabled, bool nNormal)
{
	glShadeModel(GL_SMOOTH);
	glPointSize(5);

	glEnableClientState(GL_VERTEX_ARRAY);

	glEnable(GL_SCISSOR_TEST);
	glEnable(GL_DEPTH_TEST);
	glEnable(GL_LINE_SMOOTH);
	glEnable(GL_BLEND);

	glBlendFunc(GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA);
	glHint(GL_LINE_SMOOTH_HINT, GL_DONT_CARE);

	glLightModeli(GL_LIGHT_MODEL_TWO_SIDE, GL_FALSE);

	glClearColor(0, 0, 0, 0);
	glFrustum(-1.0, 1.0, -1.0, 1.0, 1.0, 3.0);
	Light.LightInit(lEnabled, nNormal);
}

void Graphics::InitLights(bool Enabled, GLfloat AmbientColor[])
{
	Light.AmbientLight(Enabled, AmbientColor);
}

void Graphics::RenderScene(bool Gizmos, bool eLight, 
						   GLfloat AmbientColor[],
						   GLfloat BackgroundColor1[3],
						   GLfloat BackgroundColor2[3],
						   bool dSky, bool bBack, 
						   Texture *tTexture, 
						   CAMERA* cmCam, 
						   int Width, int Height, 
						   void (* View)(int X, int Y))
{
	glPushMatrix();
	if(dSky)
	{
		glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
		glClearDepth(1);
		if(bBack)
		Sky.RenderCubemap(cmCam, tTexture);
		else
		Sky.RenderBackground(View, Width, Height, BackgroundColor1, BackgroundColor2);
	}
	else
	{
		glClear(GL_DEPTH_BUFFER_BIT);
	}
	InitLights(eLight, AmbientColor);
	RenderEnvironment(Gizmos);
	glPopMatrix();
}

void Graphics::RenderGrid(bool Gizmos)
{
	if(Gizmos)
	{
	for(GLfloat i = -40; i <= 40; i += 1)
	  {
		glBegin(GL_LINES);
		glColor3f(0.5, 0.5, 0.5);
		glVertex3f(-40, 0, i);
		glVertex3f(40, 0, i);
		glVertex3f(i, 0, -40);
		glVertex3f(i, 0, 40);
		glEnd();
	  }
	}
}

void Graphics::RenderEnvironment(bool Gizmos)
{
	glDisable(GL_LIGHTING);
	glLineWidth(1.2f);
	if(Gizmos)
	{
	glBegin(GL_LINES);
	glColor3f(1, 0, 0);
	glVertex3f(0.0f, 0.0f, 0.0f);
	glVertex3f(40.0f, 0.0f, 0.0f);

	glColor3f(0, 1, 0);
	glVertex3f(0.0f, 0.0f, 0.0f);
	glVertex3f(0.0f, 40.0f, 0.0f);

	glColor3f(0, 0, 1);
	glVertex3f(0.0f, 0.0f, 0.0f);
	glVertex3f(0.0f, 0.0f, 40.0f);
	glEnd();


	glBegin(GL_LINES);
	glColor3f(1, 0, 0);
	glVertex3f(0.0f, 0.0f, 0.0f);
	glVertex3f(-40.0f, 0.0f, 0.0f);

	glColor3f(0, 1, 0);
	glVertex3f(0.0f, 0.0f, 0.0f);
	glVertex3f(0.0f, -40.0f, 0.0f);

	glColor3f(0, 0, 1);
	glVertex3f(0.0f, 0.0f, 0.0f);
	glVertex3f(0.0f, 0.0f, -40.0f);
	glEnd();

	}
	glLineWidth(1);
	RenderGrid(Gizmos);
	glEnable(GL_LIGHTING);
}