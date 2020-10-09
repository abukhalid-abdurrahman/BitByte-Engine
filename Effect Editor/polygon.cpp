//////////////////////////////////
//Разработчик: Faridun Berdiev
//****************************
//Имя Файл: polygon.cpp
//******************
//Версия: v0.1.8
//************
//Файл отвечающий за полигон
//*****************************************
//////////////////////////////////

#include "stdafx.h"
#include <windows.h>
#include "polygon.h"


POLYGON::POLYGON()
{
}

POLYGON::~POLYGON()
{
}

VECTOR POLYGON::GetNormal()
{
        VECTOR temp; 
        float ux;
        float uy;
        float uz;
        float vx;
        float vy;
        float vz;
          ux = Vertex[1].coords.x - Vertex[0].coords.x;
          uy = Vertex[1].coords.y - Vertex[0].coords.y;
          uz = Vertex[1].coords.z - Vertex[0].coords.z;
          vx = Vertex[2].coords.x - Vertex[0].coords.x;
          vy = Vertex[2].coords.y - Vertex[0].coords.y;
          vz = Vertex[2].coords.z - Vertex[0].coords.z;
          temp.x = (uy*vz)-(vy*uz);
          temp.y = (uz*vx)-(vz*ux);
          temp.z = (ux*vy)-(vx*uy);
        return temp;
}

void POLYGON::SetNormal()
{
        float ux;
        float uy;
        float uz;
        float vx;
        float vy;
        float vz;
          ux = Vertex[1].coords.x - Vertex[0].coords.x;
          uy = Vertex[1].coords.y - Vertex[0].coords.y;
          uz = Vertex[1].coords.z - Vertex[0].coords.z;
          vx = Vertex[2].coords.x - Vertex[0].coords.x;
          vy = Vertex[2].coords.y - Vertex[0].coords.y;
          vz = Vertex[2].coords.z - Vertex[0].coords.z;
          Vertex[0].normal.x = (uy*vz)-(vy*uz);
          Vertex[0].normal.y = (uz*vx)-(vz*ux);
          Vertex[0].normal.z = (ux*vy)-(vx*uy);
        Vertex[1].normal = Vertex[0].normal;
          Vertex[2].normal = Vertex[0].normal;
}
