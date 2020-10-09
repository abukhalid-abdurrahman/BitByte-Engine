//////////////////////////////////
//Разработчик: Faridun Berdiev
//****************************
//Имя Файл: object.cpp
//******************
//Версия: v0.1.8
//************
//Файл математических действий
//*****************************************
//////////////////////////////////

#include "stdafx.h"
#include "object.h"

bool freeCamera;
const float PI = 3.14f;
float radian = PI/180;

OBJECT::OBJECT()
{
    Delta_x = 0.0;
    Delta_y = 0.0;
    Delta_z = 0.0;
    Movement_x = 0.0;
    Movement_y = 0.0;
    Movement_z = 0.0;
}

OBJECT::~OBJECT()
{
}

void OBJECT::Reset()
{
    Orientation.Reset();
    Position.Reset();
    Delta_x = 0.0;
    Delta_y = 0.0;
    Delta_z = 0.0;
    Movement_x = 0.0;
    Movement_y = 0.0;
    Movement_z = 0.0;
}

void OBJECT::Rotate()
{
        VECTOR x_axis(1.0, 0.0, 0.0);
        VECTOR y_axis(0.0, 1.0, 0.0);
        Orientation.Reset();
        Orientation.AxisAngleToQuat(y_axis, Delta_y * radian);
        QUAT temp_quat;
        temp_quat.AxisAngleToQuat(x_axis, Delta_x * radian);
        Orientation.MultQuat(temp_quat);
}

void OBJECT::Draw()
{
  // Should be a pure virtual
}

void OBJECT::UpdatePosition()
{
    if (Movement_x != 0.0)
        MoveX();
    if (Movement_y != 0.0)
        MoveY();
    if (Movement_z != 0.0)
        MoveZ();
    Movement_x = 0.0;
    Movement_y = 0.0;
    Movement_z = 0.0;
}

void OBJECT::UpdatePosition(float x, float y, float z)
{
    if (x != 0.0)
        MoveX(x);
    if (y != 0.0)
        MoveY(y);
    if (z != 0.0)
        MoveZ(z);
}

void OBJECT::MoveX()
{
    float DirX;
    float DirY;
    float DirZ;
    float W;
    float X;
    float Y;
    float Z;
    QUAT TempQuat;
    QUAT TempQuat2;
    TempQuat = Orientation;
    TempQuat2.EulerToQuat(0.0f, -90.0f*(PI/180), 0.0f);
    TempQuat.MultQuat(TempQuat2);
    W = TempQuat.w;
    X = TempQuat.x;
    Y = TempQuat.y;
    Z = TempQuat.z;
    DirX = 2.0f * ( X * Z - W * Y );
    DirY = 2.0f * ( Y * Z + W * X );
    DirZ = 1.0f - 2.0f * ( X * X + Y * Y );
    Position.x += DirX * Movement_x;
    Position.y += DirY * Movement_x;
    Position.z += DirZ * Movement_x;
}

void OBJECT::MoveY()
{
    float DirX;
    float DirY;
    float DirZ;
    float W;
    float X;
    float Y;
    float Z;
    QUAT TempQuat;
    QUAT TempQuat2;
    TempQuat = Orientation;
    TempQuat2.EulerToQuat(90.0f*(PI/180), 0.0f, 0.0f);
    TempQuat.MultQuat(TempQuat2);
    W = TempQuat.w;
    X = TempQuat.x;
    Y = TempQuat.y;
    Z = TempQuat.z;
    DirX = 2.0f * ( X * Z - W * Y );
    DirY = 2.0f * ( Y * Z + W * X );
    DirZ = 1.0f - 2.0f * ( X * X + Y * Y );
    Position.x += DirX * Movement_y;
    Position.y += DirY * Movement_y;
    Position.z += DirZ * Movement_y;
}

void OBJECT::MoveZ()
{
    float DirX;
    float DirY;
    float DirZ;
    float W = Orientation.w;
    float X = Orientation.x;
    float Y = Orientation.y;
    float Z = Orientation.z;
    DirX = 2.0f * ( X * Z - W * Y );
    DirY = 2.0f * ( Y * Z + W * X );
    DirZ = 1.0f - 2.0f * ( X * X + Y * Y );
    Position.x += DirX * Movement_z;
    Position.y += DirY * Movement_z;
    Position.z += DirZ * Movement_z;
}

void OBJECT::MoveX(float x)
{
    float DirX;
    float DirY;
    float DirZ;
    float W;
    float X;
    float Y;
    float Z;
    QUAT TempQuat;
    QUAT TempQuat2;
    TempQuat = Orientation;
    TempQuat2.EulerToQuat(0.0f, -90.0f*(PI/180), 0.0f);
    TempQuat.MultQuat(TempQuat2);
    W = TempQuat.w;
    X = TempQuat.x;
    Y = TempQuat.y;
    Z = TempQuat.z;
    DirX = 2.0f * ( X * Z - W * Y );
    DirY = 2.0f * ( Y * Z + W * X );
    DirZ = 1.0f - 2.0f * ( X * X + Y * Y );
    Position.x += DirX * x;
    Position.y += DirY * x;
    Position.z += DirZ * x;
}

void OBJECT::MoveY(float y)
{
    float DirX;
    float DirY;
    float DirZ;
    float W;
    float X;
    float Y;
    float Z;
    QUAT TempQuat;
    QUAT TempQuat2;
    TempQuat = Orientation;
    TempQuat2.EulerToQuat(90.0f*(PI/180), 0.0f, 0.0f);
    TempQuat.MultQuat(TempQuat2);
    W = TempQuat.w;
    X = TempQuat.x;
    Y = TempQuat.y;
    Z = TempQuat.z;
    DirX = 2.0f * ( X * Z - W * Y );
    DirY = 2.0f * ( Y * Z + W * X );
    DirZ = 1.0f - 2.0f * ( X * X + Y * Y );
    Position.x += DirX * y;
    Position.y += DirY * y;
    Position.z += DirZ * y;
}

void OBJECT::MoveZ(float z)
{
    float DirX;
    float DirY;
    float DirZ;
    float W = Orientation.w;
    float X = Orientation.x;
    float Y = Orientation.y;
    float Z = Orientation.z;
    DirX = 2.0f * ( X * Z - W * Y );
    DirY = 2.0f * ( Y * Z + W * X );
    DirZ = 1.0f - 2.0f * ( X * X + Y * Y );
    Position.x += DirX * z;
    Position.y += DirY * z;
    Position.z += DirZ * z;
}

VECTOR OBJECT::GetXUnit()
{
    float DirX;
    float DirY;
    float DirZ;
    float W;
    float X;
    float Y;
    float Z;
    QUAT TempQuat;
    QUAT TempQuat2;
    TempQuat = Orientation;
    TempQuat2.EulerToQuat(0.0f, -90.0f*(PI/180), 0.0f);
    TempQuat.MultQuat(TempQuat2);
    W = TempQuat.w;
    X = TempQuat.x;
    Y = TempQuat.y;
    Z = TempQuat.z;
    DirX = 2.0f * ( X * Z - W * Y );
    DirY = 2.0f * ( Y * Z + W * X );
    DirZ = 1.0f - 2.0f * ( X * X + Y * Y );
    VECTOR Unit;
    Unit.x += DirX * 1;
    Unit.y += DirY * 1;
    Unit.z += DirZ * 1;
    return Unit;
}

VECTOR OBJECT::GetYUnit()
{
    float DirX;
    float DirY;
    float DirZ;
    float W;
    float X;
    float Y;
    float Z;
    QUAT TempQuat;
    QUAT TempQuat2;
    TempQuat = Orientation;
    TempQuat2.EulerToQuat(90.0f*(PI/180), 0.0f, 0.0f);
    TempQuat.MultQuat(TempQuat2);
    W = TempQuat.w;
    X = TempQuat.x;
    Y = TempQuat.y;
    Z = TempQuat.z;
    DirX = 2.0f * ( X * Z - W * Y );
    DirY = 2.0f * ( Y * Z + W * X );
    DirZ = 1.0f - 2.0f * ( X * X + Y * Y );
    VECTOR Unit;
    Unit.x += DirX * 1;
    Unit.y += DirY * 1;
    Unit.z += DirZ * 1;
    return Unit;
}

VECTOR OBJECT::GetZUnit()
{
    float DirX;
    float DirY;
    float DirZ;
    float W = Orientation.w;
    float X = Orientation.x;
    float Y = Orientation.y;
    float Z = Orientation.z;
    DirX = 2.0f * ( X * Z - W * Y );
    DirY = 2.0f * ( Y * Z + W * X );
    DirZ = 1.0f - 2.0f * ( X * X + Y * Y );
    VECTOR Unit;
    Unit.x += DirX * 1;
    Unit.y += DirY * 1;
    Unit.z += DirZ * 1;
    return Unit;
}

