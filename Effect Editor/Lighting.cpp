//////////////////////////////////
//Разработчик: Faridun Berdiev
//****************************
//Имя Файл: Lighting.cpp
//******************
//Версия: v0.1.8
//************
//Файл отвечающий за источники освещение
//*****************************************
//////////////////////////////////

#include "stdafx.h"
#include "Lighting.h"

Lighting::Lighting(void)
{
}


Lighting::~Lighting(void)
{
}


void Lighting::AmbientLight(bool Enabled, GLfloat AmbientColor[])
{
	if(Enabled)
	{
	   glEnable(GL_LIGHTING);
	   glEnable(GL_LIGHT0);
	   glLightfv(GL_LIGHT0, GL_AMBIENT, AmbientColor);
	}
	else
	{
	   glDisable(GL_LIGHTING);
	   glDisable(GL_LIGHT0);
	}
}

void Lighting::SetMaterial(GLfloat Color[4])
{
	glEnable(GL_LIGHTING);
	GLfloat Shininess = 0.1f * 128;
	glMaterialfv(GL_FRONT, GL_AMBIENT, Color);
	glMaterialfv(GL_FRONT, GL_DIFFUSE, Color);
    glMaterialfv(GL_FRONT, GL_SPECULAR, Color);
    glMaterialf(GL_FRONT, GL_SHININESS, Shininess);
}

void Lighting::LightInit(bool Enabled, bool Normalize)
{
	if(!Enabled)
	{
		if(!Normalize)
		{
			glDisable(GL_NORMALIZE);
			return;
		}
		else if(Normalize) 
		{
			glEnable(GL_NORMALIZE);
		}
		glDisable(GL_LIGHTING);
		return;
	}
	else if(Enabled)
	{
		if(!Normalize)
		{
			glDisable(GL_NORMALIZE);
			return;
		}
		else if(Normalize) 
		{
			glEnable(GL_NORMALIZE);
		}

		glEnable(GL_LIGHTING);
	}
}

void Lighting::PointLight(GLenum lNum, bool Enabled, bool Gizmos, 
						  glm::vec3 Position,
						  GLfloat PointLightColor[], 
						  float LRadius)
{

    GLfloat PointLightPosition[4];
	PointLightPosition[0] = Position.x;
	PointLightPosition[1] = Position.y;
	PointLightPosition[2] = Position.z;
	PointLightPosition[3] = 1.0f;

	if(!Enabled)
	{
		glDisable(lNum);
	}
	else if(Enabled)
	{
	  glEnable(GL_LIGHTING);
	  glPushMatrix();
	  glEnable(lNum);
	  glLightfv(lNum, GL_SHININESS, PointLightColor);
	  glLightfv(lNum, GL_SPECULAR, PointLightColor);
	  glLightfv(lNum, GL_DIFFUSE, PointLightColor);
	  glLightfv(lNum, GL_POSITION, PointLightPosition);
      glLightf(lNum, GL_CONSTANT_ATTENUATION, 1.0f);
      glLightf(lNum, GL_LINEAR_ATTENUATION, 0.0f);
	  glLightf(lNum, GL_QUADRATIC_ATTENUATION, 1.0f/LRadius);
	  if(Gizmos)
	  {
	     glPushMatrix();
		 glTranslatef(Position.x, Position.y, Position.z);
	     glDisable(GL_LIGHTING);
		 glDisable(lNum);
	     glColor3f(0.7f, 0.7f, 1);
	     glutWireSphere(LRadius, 8, 8);
		 glPushMatrix();
		 glEnable(GL_BLEND);
		 glBlendFunc(GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA);
		 glColor4f(1.0f, 1.0f, 1.0f, 0.3f);
		 glutSolidSphere(LRadius, 8, 8);
		 glDisable(GL_BLEND);
		 glPopMatrix();
	     glEnable(GL_LIGHTING);
		 glEnable(lNum);
	     glPopMatrix();
	  }
	  glPopMatrix();
	}
}

void Lighting::SpotLight(GLenum lNum, bool Enabled, bool Gizmos,
						 glm::vec3 Position,
						 GLfloat SpotDirection[],
						 GLfloat SpotLightColor[])
{
	GLfloat SpotLightPosition[4];
	SpotLightPosition[0] = Position.x;
	SpotLightPosition[1] = Position.y;
	SpotLightPosition[2] = Position.z;
	SpotLightPosition[3] = 1.0f;

	if(!Enabled)
	{
		glDisable(lNum);
	}
	else if(Enabled)
	{
	  glPushMatrix();
      glEnable(lNum);
	  glLightfv(lNum, GL_SPECULAR, SpotLightColor);
	  glLightfv(lNum, GL_DIFFUSE, SpotLightColor);
	  glLightfv(lNum, GL_POSITION, SpotLightPosition);
      glLightf(lNum, GL_SPOT_CUTOFF, 30);
	  glLightfv(lNum, GL_SPOT_DIRECTION, SpotDirection);
	  glLightf(lNum, GL_SPOT_EXPONENT, 15);
	  if(Gizmos)
	  {
	     glPushMatrix();
		 glTranslatef(Position.x, Position.y, Position.z);
	     glDisable(GL_LIGHTING);
	     glColor3f(0.7f, 0.7f, 1);
		 glutSolidSphere(0.3, 16, 16); 
	     glEnable(GL_LIGHTING);
	     glPopMatrix();
	  }
	  glPopMatrix();
	}
}

void Lighting::DirectionalLight(GLenum lNum, bool Enabled,
								GLfloat LDirection[],
								GLfloat DirectionalLightColor[])
{
	if(!Enabled)
	{
		glDisable(lNum);
	}
	else if(Enabled)
	{
	   glPushMatrix();
	   glEnable(GL_LIGHTING);
	   glEnable(lNum);
	   glLightfv(lNum, GL_AMBIENT, DirectionalLightColor);
	   glLightfv(lNum, GL_DIFFUSE, DirectionalLightColor);
	   glLightfv(lNum, GL_SPECULAR, DirectionalLightColor);
	   glLightfv(lNum, GL_POSITION, LDirection);
	   glPopMatrix();
	}
}
