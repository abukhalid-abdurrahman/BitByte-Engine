#pragma once

#include "stdafx.h"

#include "glm\glm\glm.hpp"

struct GameObject
{
	char Name[4];
	bool isActive, 
		 isColorBlended;

	GLfloat MaterialColor[4];

	GLfloat RotAngle, 
		    RotX, 
		    RotY, 
		    RotZ;

	glm::vec3 Position,
			  Scale;
};

struct AudioSource
{
	char Name[4];
	bool isActive, 
		 isPlay, 
		 isLoop;

	float Volume;
};

struct PointLight
{
	char Name[4];
	bool isActive;

	GLfloat PointLightColor[3];

    float PointLightRadius;

	glm::vec3 Position;
};

struct SpotLight
{
	char Name[4];
	bool isActive;

	GLfloat SpotLightColor[3], 
		    SpotDirection[4];

	glm::vec3 Position;
};

struct DirectionalLight
{
	char Name[4];
	bool isActive;

	GLfloat DirectionalLightColor[3],
		    LightDirection[3];
};