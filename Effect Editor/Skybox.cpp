//////////////////////////////////
//Разработчик: Faridun Berdiev
//****************************
//Имя Файл: Skybox.cpp
//******************
//Версия: v0.1.8
//************
//Файл отвечающий за прорисовку неба
//*****************************************
//////////////////////////////////

#include "stdafx.h"
#include "Skybox.h"
#include "locmath.h"
#include "polygon.h"

#pragma warning(disable : 4996)

using namespace std;

Skybox::Skybox(void)
{
}


Skybox::~Skybox(void)
{
}

void Skybox::SetWorld(POLYGON *pPolygon)
{
	pPolygon[0].numVertices = 3;
    pPolygon[0].Vertex[0].coords.x = -1.0;
    pPolygon[0].Vertex[0].coords.y = -1.0;
    pPolygon[0].Vertex[0].coords.z = -4.0;
    pPolygon[0].Vertex[1].coords.x = 1.0;
    pPolygon[0].Vertex[1].coords.y = -1.0;
    pPolygon[0].Vertex[1].coords.z = -4.0;
    pPolygon[0].Vertex[2].coords.x = 1.0;
    pPolygon[0].Vertex[2].coords.y = 1.0;
    pPolygon[0].Vertex[2].coords.z = -4.0;

    pPolygon[1].numVertices = 3;
    pPolygon[1].Vertex[0].coords.x = -1.0;
    pPolygon[1].Vertex[0].coords.y = -1.0;
    pPolygon[1].Vertex[0].coords.z = -4.0;
    pPolygon[1].Vertex[1].coords.x = 1.0;
    pPolygon[1].Vertex[1].coords.y = 1.0;
    pPolygon[1].Vertex[1].coords.z = -4.0;
    pPolygon[1].Vertex[2].coords.x = -1.0;
    pPolygon[1].Vertex[2].coords.y = 1.0;
    pPolygon[1].Vertex[2].coords.z = -4.0;

    pPolygon[2].numVertices = 3;
    pPolygon[2].Vertex[0].coords.x = 1.0;
    pPolygon[2].Vertex[0].coords.y = -1.0;
    pPolygon[2].Vertex[0].coords.z = -6.0;
    pPolygon[2].Vertex[1].coords.x = -1.0;
    pPolygon[2].Vertex[1].coords.y = -1.0;
    pPolygon[2].Vertex[1].coords.z = -6.0;
    pPolygon[2].Vertex[2].coords.x = -1.0;
    pPolygon[2].Vertex[2].coords.y = 1.0;
    pPolygon[2].Vertex[2].coords.z = -6.0;

    pPolygon[3].numVertices = 3;
    pPolygon[3].Vertex[0].coords.x = 1.0;
    pPolygon[3].Vertex[0].coords.y = -1.0;
    pPolygon[3].Vertex[0].coords.z = -6.0;
    pPolygon[3].Vertex[1].coords.x = -1.0;
    pPolygon[3].Vertex[1].coords.y = 1.0;
    pPolygon[3].Vertex[1].coords.z = -6.0;
    pPolygon[3].Vertex[2].coords.x = 1.0;
    pPolygon[3].Vertex[2].coords.y = 1.0;
    pPolygon[3].Vertex[2].coords.z = -6.0;

    pPolygon[4].numVertices = 3;
    pPolygon[4].Vertex[0].coords.x = -1.0;
    pPolygon[4].Vertex[0].coords.y = -1.0;
    pPolygon[4].Vertex[0].coords.z = -6.0;
    pPolygon[4].Vertex[1].coords.x = -1.0;
    pPolygon[4].Vertex[1].coords.y = -1.0;
    pPolygon[4].Vertex[1].coords.z = -4.0;
    pPolygon[4].Vertex[2].coords.x = -1.0;
    pPolygon[4].Vertex[2].coords.y = 1.0;
    pPolygon[4].Vertex[2].coords.z = -4.0;

    pPolygon[5].numVertices = 3;
    pPolygon[5].Vertex[0].coords.x = -1.0;
    pPolygon[5].Vertex[0].coords.y = -1.0;
    pPolygon[5].Vertex[0].coords.z = -6.0;
    pPolygon[5].Vertex[1].coords.x = -1.0;
    pPolygon[5].Vertex[1].coords.y = 1.0;
    pPolygon[5].Vertex[1].coords.z = -4.0;
    pPolygon[5].Vertex[2].coords.x = -1.0;
    pPolygon[5].Vertex[2].coords.y = 1.0;
    pPolygon[5].Vertex[2].coords.z = -6.0;

    pPolygon[6].numVertices = 3;
    pPolygon[6].Vertex[0].coords.x = 1.0;
    pPolygon[6].Vertex[0].coords.y = -1.0;
    pPolygon[6].Vertex[0].coords.z = -4.0;
    pPolygon[6].Vertex[1].coords.x = 1.0;
    pPolygon[6].Vertex[1].coords.y = -1.0;
    pPolygon[6].Vertex[1].coords.z = -6.0;
    pPolygon[6].Vertex[2].coords.x = 1.0;
    pPolygon[6].Vertex[2].coords.y = 1.0;
    pPolygon[6].Vertex[2].coords.z = -6.0;

    pPolygon[7].numVertices = 3;
    pPolygon[7].Vertex[0].coords.x = 1.0;
    pPolygon[7].Vertex[0].coords.y = -1.0;
    pPolygon[7].Vertex[0].coords.z = -4.0;
    pPolygon[7].Vertex[1].coords.x = 1.0;
    pPolygon[7].Vertex[1].coords.y = 1.0;
    pPolygon[7].Vertex[1].coords.z = -6.0;
    pPolygon[7].Vertex[2].coords.x = 1.0;
    pPolygon[7].Vertex[2].coords.y = 1.0;
    pPolygon[7].Vertex[2].coords.z = -4.0;

    pPolygon[8].numVertices = 3;
    pPolygon[8].Vertex[0].coords.x = 1.0;
    pPolygon[8].Vertex[0].coords.y = 1.0;
    pPolygon[8].Vertex[0].coords.z = -4.0;
    pPolygon[8].Vertex[1].coords.x = 1.0;
    pPolygon[8].Vertex[1].coords.y = 1.0;
    pPolygon[8].Vertex[1].coords.z = -6.0;
    pPolygon[8].Vertex[2].coords.x = -1.0;
    pPolygon[8].Vertex[2].coords.y = 1.0;
    pPolygon[8].Vertex[2].coords.z = -6.0;

    pPolygon[9].numVertices = 3;
    pPolygon[9].Vertex[0].coords.x = 1.0;
    pPolygon[9].Vertex[0].coords.y = 1.0;
    pPolygon[9].Vertex[0].coords.z = -4.0;
    pPolygon[9].Vertex[1].coords.x = -1.0;
    pPolygon[9].Vertex[1].coords.y = 1.0;
    pPolygon[9].Vertex[1].coords.z = -6.0;
    pPolygon[9].Vertex[2].coords.x = -1.0;
    pPolygon[9].Vertex[2].coords.y = 1.0;
    pPolygon[9].Vertex[2].coords.z = -4.0;

    pPolygon[10].numVertices = 3;
    pPolygon[10].Vertex[0].coords.x = -1.0;
    pPolygon[10].Vertex[0].coords.y = -1.0;
    pPolygon[10].Vertex[0].coords.z = -4.0;
    pPolygon[10].Vertex[1].coords.x = -1.0;
    pPolygon[10].Vertex[1].coords.y = -1.0;
    pPolygon[10].Vertex[1].coords.z = -6.0;
    pPolygon[10].Vertex[2].coords.x = 1.0;
    pPolygon[10].Vertex[2].coords.y = -1.0;
    pPolygon[10].Vertex[2].coords.z = -6.0;

    pPolygon[11].numVertices = 3;
    pPolygon[11].Vertex[0].coords.x = -1.0;
    pPolygon[11].Vertex[0].coords.y = -1.0;
    pPolygon[11].Vertex[0].coords.z = -4.0;
    pPolygon[11].Vertex[1].coords.x = 1.0;
    pPolygon[11].Vertex[1].coords.y = -1.0;
    pPolygon[11].Vertex[1].coords.z = -6.0;
    pPolygon[11].Vertex[2].coords.x = 1.0;
    pPolygon[11].Vertex[2].coords.y = -1.0;
    pPolygon[11].Vertex[2].coords.z = -4.0;

    pPolygon[0].SetNormal();
    pPolygon[1].SetNormal();
    pPolygon[2].SetNormal();
    pPolygon[3].SetNormal();
    pPolygon[4].SetNormal();
    pPolygon[5].SetNormal();
    pPolygon[6].SetNormal();
    pPolygon[7].SetNormal();
    pPolygon[8].SetNormal();
    pPolygon[9].SetNormal();
    pPolygon[10].SetNormal();
    pPolygon[11].SetNormal();

}

void Skybox::RenderCubemap(CAMERA *cam, Texture* cTexture)
{
	int cmCurCamera = 0;
	float SkySize = 1054;

	glPushMatrix();
	VECTOR facenormal;
    VECTOR SkyboxVertex[8];

    SkyboxVertex[0].x = cam[cmCurCamera].Position.x - SkySize;
    SkyboxVertex[0].y = cam[cmCurCamera].Position.y - SkySize;
    SkyboxVertex[0].z = cam[cmCurCamera].Position.z + SkySize;

    SkyboxVertex[1].x = cam[cmCurCamera].Position.x - SkySize;
    SkyboxVertex[1].y = cam[cmCurCamera].Position.y - SkySize;
    SkyboxVertex[1].z = cam[cmCurCamera].Position.z - SkySize;

    SkyboxVertex[2].x = cam[cmCurCamera].Position.x + SkySize;
    SkyboxVertex[2].y = cam[cmCurCamera].Position.y - SkySize;
    SkyboxVertex[2].z = cam[cmCurCamera].Position.z - SkySize;

    SkyboxVertex[3].x = cam[cmCurCamera].Position.x + SkySize;
    SkyboxVertex[3].y = cam[cmCurCamera].Position.y - SkySize;
    SkyboxVertex[3].z = cam[cmCurCamera].Position.z + SkySize;

    SkyboxVertex[4].x = cam[cmCurCamera].Position.x - SkySize;
    SkyboxVertex[4].y = cam[cmCurCamera].Position.y + SkySize;
    SkyboxVertex[4].z = cam[cmCurCamera].Position.z + SkySize;

    SkyboxVertex[5].x = cam[cmCurCamera].Position.x - SkySize;
    SkyboxVertex[5].y = cam[cmCurCamera].Position.y + SkySize;
    SkyboxVertex[5].z = cam[cmCurCamera].Position.z - SkySize;

    SkyboxVertex[6].x = cam[cmCurCamera].Position.x + SkySize;
    SkyboxVertex[6].y = cam[cmCurCamera].Position.y + SkySize;
    SkyboxVertex[6].z = cam[cmCurCamera].Position.z - SkySize;

    SkyboxVertex[7].x = cam[cmCurCamera].Position.x + SkySize;
    SkyboxVertex[7].y = cam[cmCurCamera].Position.y + SkySize;
    SkyboxVertex[7].z = cam[cmCurCamera].Position.z + SkySize;

    glDisable(GL_LIGHTING);
	glEnable(GL_TEXTURE_2D);
    glPushMatrix();
    glColor3f(1.0f, 1.0f, 1.0f);
    // Left Face
    glBindTexture(GL_TEXTURE_2D, cTexture[4].tTexID);
    glBegin(GL_QUADS);
        facenormal = GetNormal(SkyboxVertex[6], SkyboxVertex[0], SkyboxVertex[3]);
        glNormal3fv(&facenormal.x);
        glTexCoord2f(0.0f, 0.0f); glVertex3fv(&SkyboxVertex[0].x);
        glTexCoord2f(1.0f, 0.0f); glVertex3fv(&SkyboxVertex[1].x);
        glTexCoord2f(1.0f, 1.0f); glVertex3fv(&SkyboxVertex[5].x);
        glTexCoord2f(0.0f, 1.0f); glVertex3fv(&SkyboxVertex[4].x);
    glEnd();

    // Back Face
    glBindTexture(GL_TEXTURE_2D, cTexture[7].tTexID);
    glBegin(GL_QUADS);
        facenormal = GetNormal(SkyboxVertex[4], SkyboxVertex[5], SkyboxVertex[7]);
        glNormal3fv(&facenormal.x);
        glTexCoord2f(0.0f, 0.0f); glVertex3fv(&SkyboxVertex[1].x);
        glTexCoord2f(1.0f, 0.0f); glVertex3fv(&SkyboxVertex[2].x);
        glTexCoord2f(1.0f, 1.0f); glVertex3fv(&SkyboxVertex[6].x);
        glTexCoord2f(0.0f, 1.0f); glVertex3fv(&SkyboxVertex[5].x);
    glEnd();

    // Right Face
    glBindTexture(GL_TEXTURE_2D, cTexture[5].tTexID);
    glBegin(GL_QUADS);
        facenormal = GetNormal(SkyboxVertex[1], SkyboxVertex[7], SkyboxVertex[5]);
        glNormal3fv(&facenormal.x);
        glTexCoord2f(0.0f, 0.0f); glVertex3fv(&SkyboxVertex[2].x);
        glTexCoord2f(1.0f, 0.0f); glVertex3fv(&SkyboxVertex[3].x);
        glTexCoord2f(1.0f, 1.0f); glVertex3fv(&SkyboxVertex[7].x);
        glTexCoord2f(0.0f, 1.0f); glVertex3fv(&SkyboxVertex[6].x);
    glEnd();

    // Front Face
    glBindTexture(GL_TEXTURE_2D, cTexture[6].tTexID);
    glBegin(GL_QUADS);
        glColor3f(1.0f,1.0f,1.0f);
        facenormal = GetNormal(SkyboxVertex[0], SkyboxVertex[1], SkyboxVertex[2]);
        glNormal3fv(&facenormal.x);
        glTexCoord2f(0.0f, 0.0f); glVertex3fv(&SkyboxVertex[3].x);
        glTexCoord2f(1.0f, 0.0f); glVertex3fv(&SkyboxVertex[0].x);
        glTexCoord2f(1.0f, 1.0f); glVertex3fv(&SkyboxVertex[4].x);
        glTexCoord2f(0.0f, 1.0f); glVertex3fv(&SkyboxVertex[7].x);
    glEnd();

    // Top Face
    glBindTexture(GL_TEXTURE_2D, cTexture[2].tTexID);
    glBegin(GL_QUADS);
        facenormal = GetNormal(SkyboxVertex[3], SkyboxVertex[2], SkyboxVertex[5]);
        glNormal3fv(&facenormal.x);
        glTexCoord2f(0.0f, 0.0f); glVertex3fv(&SkyboxVertex[7].x);
        glTexCoord2f(1.0f, 0.0f); glVertex3fv(&SkyboxVertex[4].x);
        glTexCoord2f(1.0f, 1.0f); glVertex3fv(&SkyboxVertex[5].x);
        glTexCoord2f(0.0f, 1.0f); glVertex3fv(&SkyboxVertex[6].x);
    glEnd();
    glPopMatrix();
	glDisable(GL_TEXTURE_2D);
    glEnable(GL_LIGHTING);

	glPopMatrix();
}

void Skybox::RenderBackground(void (* View)(int X, int Y), 
							  int x_X, int y_Y, 
							  GLfloat BackgroundColor1[3], GLfloat BackgroundColor2[3])
{
	glPushMatrix();
	glPolygonMode(GL_FRONT_AND_BACK, GL_FILL);
    glDisable(GL_LIGHTING);
    glMatrixMode(GL_PROJECTION);
    glPushMatrix();
    glLoadIdentity();
    glMatrixMode(GL_MODELVIEW);
    glPushMatrix();
    glLoadIdentity();
    glBegin(GL_QUADS);
        glColor3f(BackgroundColor2[0], BackgroundColor2[1], BackgroundColor2[2]);
        glVertex3f(-1, -1, 0.9f); 
        glVertex3f(1, -1, 0.9f); 
	    glColor3f(BackgroundColor1[0], BackgroundColor1[1], BackgroundColor1[2]);
        glVertex3f(1, 1, 0.9f); 
        glVertex3f(-1, 1, 0.9f);
    glEnd();
	View(x_X, y_Y);
    glEnable(GL_LIGHTING);
    glPopMatrix();
}