//////////////////////////////////
//Разработчик: Faridun Berdiev
//****************************
//Имя Файл: camera.cpp
//******************
//Версия: v0.1.8
//************
//Файл отвечающий за камеру
//*****************************************
//////////////////////////////////

#include "stdafx.h"
#include "camera.h"

CAMERA::CAMERA()
{
}

CAMERA::~CAMERA()
{
}

void CAMERA::Reset()
{
    Orientation.Reset();
    Position.Reset();
    Delta_x = 0.0;
    Delta_y = 0.0;
    Delta_z = 0.0;
    Matrix.LoadIdentity();
}

void CAMERA::Update()
{
    Rotate();
    UpdatePosition();
}

void CAMERA::Apply()
{
    Matrix.QuatToMatrix(Orientation);
    Matrix.MatrixInverse();

    glLoadMatrixf(Matrix.Element);
    glTranslatef(-Position.x,-Position.y,-Position.z);
}
