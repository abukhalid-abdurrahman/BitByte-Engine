//////////////////////////////////
//�����������: Faridun Berdiev
//****************************
//��� ����: vector.cpp
//******************
//������: v0.1.8
//************
//���� �������������� ��������
//*****************************************
//////////////////////////////////

#include "stdafx.h"
#include <windows.h>
#include <cmath>
#include "vector.h"


VECTOR::VECTOR(float sx, float sy, float sz)
:
    x(sx),
    y(sy),
    z(sz)
{
}

VECTOR::VECTOR(const VECTOR& Vector)
{
    x = Vector.x;
    y = Vector.y;
    z = Vector.z;
}

VECTOR::~VECTOR()
{
}

void VECTOR::Reset()
{
    x = 0;
    y = 0;
    z = 0;
}

float VECTOR::DotProduct(VECTOR vect)
{
      float dot;
      dot = vect.x * x + vect.y * y + vect.z * z;
      return dot;
}

void VECTOR::CrossVector(VECTOR vect)
{
      VECTOR temp = *this;
      x = vect.y * temp.z - vect.z * temp.y;
      y = vect.z * temp.x - vect.x * temp.z;
      z = vect.x * temp.y - vect.y * temp.x;
}

float VECTOR::GetMagnitude()
{
    float magnitude = (float)sqrt(x * x + y * y + z * z);
    if (magnitude != 0.0f)
        return magnitude;
    else
        return 0.000001f;
}

void VECTOR::Normalize()
{
    float magnitude = this->GetMagnitude();
    x /= magnitude;
    y /= magnitude;
    z /= magnitude;
}
