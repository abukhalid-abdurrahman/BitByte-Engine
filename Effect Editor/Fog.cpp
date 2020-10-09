//////////////////////////////////
//�����������: Faridun Berdiev
//****************************
//��� ����: Lighting.cpp
//******************
//������: v0.1.8
//************
//���� ���������� �� ���������� ������
//*****************************************
//////////////////////////////////

#include "stdafx.h"
#include "Fog.h"


Fog::Fog(void)
{
}


Fog::~Fog(void)
{
}

void Fog::FogInit(bool Enabled, float FogColor[4], float FogStart, float FogEnd)
{
	FogColor[4] = 1;
	if(!Enabled)
	{
		glDisable(GL_FOG);
		return;
	}
	else if(Enabled)
	{
	    glEnable(GL_FOG);
		glFogi(GL_FOG_MODE, GL_LINEAR);
	    glFogf(GL_FOG_START, FogStart);
        glFogf(GL_FOG_END, FogEnd);
		glFogfv(GL_FOG_COLOR, FogColor);
	}
}
