//////////////////////////////////
//�����������: Faridun Berdiev
//****************************
//��� ����: vertex.cpp
//******************
//������: v0.1.8
//************
//���� �������������� ��������
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

