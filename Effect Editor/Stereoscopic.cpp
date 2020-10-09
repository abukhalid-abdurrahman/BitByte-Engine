//////////////////////////////////
//Разработчик: Faridun Berdiev
//****************************
//Имя Файл: Stereoscopic.cpp
//******************
//Версия: v0.1.8
//************
//Стереоскопический режи в FGE
//*****************************************
//////////////////////////////////

#include "stdafx.h"
#include "Stereoscopic.h"

Stereoscopic::Stereoscopic(void)
{
}

Stereoscopic::~Stereoscopic(void)
{
}

void Stereoscopic::InitStereoscopic(void(*RenderFunction)(void), GLfloat EyeOffset)
{
	glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
	glTranslatef(EyeOffset, EyeOffset, EyeOffset);
	glColorMask(0, 1, 1, 1);
	RenderFunction();
	glClear(GL_DEPTH_BUFFER_BIT);
	glTranslatef(-EyeOffset, -EyeOffset, -EyeOffset);
	glColorMask(1, 0, 0, 1);
	RenderFunction();
	glColorMask(1, 1, 1, 1);
}