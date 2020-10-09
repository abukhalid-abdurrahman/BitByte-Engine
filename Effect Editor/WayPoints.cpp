//////////////////////////////////
//Разработчик: Faridun Berdiev
//****************************
//Имя Файл: WayPoints.cpp
//******************
//Версия: v0.1.8
//************
//Перемещение различных объектов по сцене
//*****************************************
//////////////////////////////////

#include "stdafx.h"
#include "WayPoints.h"

#include "glm\glm\glm.hpp"

WayPoints::WayPoints(void)
{
	//Nothing to do...
}

WayPoints::~WayPoints(void)
{
	//Nothing to do...
}


void WayPoints::PlayWayPointAnimation(Coordinates Coord, GLfloat Time, GLfloat Speed, GLboolean *Stop)
{
	GLfloat LastX = 0, LastY = 0, LastZ = 0;
	glTranslatef(LastX = Coord.X*Time/Speed, LastY = Coord.Y*Time/Speed, LastZ = Coord.Z*Time/Speed);
		
	if(LastX >= Coord.X || LastY >= Coord.Y || LastZ >= Coord.Z)
	{
		*Stop = GL_TRUE;
	}
}

void WayPoints::TranslateToPosition(Coordinates Coord)
{
	glTranslatef(Coord.X, Coord.Y, Coord.Z);
}