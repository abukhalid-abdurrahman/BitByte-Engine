//////////////////////////////////
//Разработчик: Faridun Berdiev
//****************************
//Имя Файл: Text.cpp
//******************
//Версия: v0.1.8
//************
//Файл отвечающий за прорисовку текста
//*****************************************
//////////////////////////////////

#include "stdafx.h"
#include "Text.h"


Text::Text(void)
{
}

Text::~Text(void)
{
}

void Text::RenderText3D(void *Font, char *Text, float X, float Y, float Z, float TextWidth)
{
	char *i;
	glLineWidth(TextWidth);
	glRasterPos3f(X, Y, Z);

	for(i = Text; *i != ' '; i++)
	{
		glutBitmapCharacter(Font, *i);
	}
	glLineWidth(1);
}

void Text::RenderText2D(void *Font, char *Text, float X, float Y, float TextWidth)
{
	char *i;
	glLineWidth(TextWidth);
	glRasterPos3f(X, Y, 0);

	for(i = Text; *i != '\0'; i++)
	{
		glutBitmapCharacter(Font, *i);
	}
	glLineWidth(1);
}

void Text::RenderTextObject(void *Font, char *Text, float X, float Y, float Z, float rX, float rY, float rZ, float sX, float sY, float sZ, float TextWidth)
{
	glPushMatrix();
	char *i;

	glLineWidth(TextWidth);
	glTranslatef(X, Y, Z);
	glRotatef(0, rX, rY, rZ);
	glScalef(sX, sY, sZ);

	for(i = Text; *i != ' '; i++)
	{
		glutStrokeCharacter(Font, *i);
	}
	glLineWidth(1);
	glPopMatrix();
}

