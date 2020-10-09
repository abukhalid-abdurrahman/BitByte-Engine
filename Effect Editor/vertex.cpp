//////////////////////////////////
//Разработчик: Faridun Berdiev
//****************************
//Имя Файл: vertex.cpp
//******************
//Версия: v0.1.8
//************
//Файл математических действий
//*****************************************
//////////////////////////////////

#include "stdafx.h"
#include <windows.h>
#include "vertex.h"


VERTEX::VERTEX(float sx, float sy, float sz, float snx, float sny, float snz)
{
    coords.x = sx;
    coords.y = sy;
    coords.z = sz;
    normal.x = snx;
    normal.y = sny;
    normal.z = snz;
}

VERTEX::~VERTEX()
{
}

