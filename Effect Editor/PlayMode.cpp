//////////////////////////////////
//Разработчик: Faridun Berdiev
//****************************
//Имя Файл: PlayMode.cpp
//******************
//Версия: v0.1.8
//************
//Вход в игровой режим
//*****************************************
//////////////////////////////////s

#include "stdafx.h"
#include "PlayMode.h"

#pragma warning(disable : 4996)

PlayMode pm_Mode;
Text StateText[2];

int PMWWidth = 720, PMWHeight = 480;

PlayMode::PlayMode(void)
{
	isPlayMode = GL_FALSE;
	isFullScreen = GL_FALSE;
}

PlayMode::~PlayMode(void)
{
	delete[] this->FPS;
	delete[] this->GS;
	delete[] StateText;
}

void PlayMode::RenderStates()
{
	StateText[0].RenderText2D(GLUT_BITMAP_8_BY_13, FPS, 0, 10, 3);
	StateText[1].RenderText2D(GLUT_BITMAP_8_BY_13, GS,  0, 25, 3);
}

void PlayMode::FramePerSecond()
{
	Frame++;
	Time = glutGet(GLUT_ELAPSED_TIME);

	if(Time - TimeBase > 1000)
	{
		sprintf(FPS, "Frame Per Second: %4.2f", Frame * 1000.0 / (Time - TimeBase));
		TimeBase = Time;
		Frame = 0;
	}
}

void PlayMode::GetMode()
{
	if(isPlayMode)
		sprintf(GS, "MODE : PLAY");
	else if(!isPlayMode)
		sprintf(GS, "MODE : EDITOR");
}

int PlayMode::SCREEN_WIDTH()
{
	return glutGet(GLUT_SCREEN_WIDTH);
}

int PlayMode::SCREEN_HEIGHT()
{
	return glutGet(GLUT_SCREEN_HEIGHT);
}

void PlayMode::Play(bool *Gizmos)
{
   *Gizmos = false;
   isPlayMode = GL_TRUE;

   glutSetWindowTitle("Effect Editor - Play Mode");

   Log("GAME-MODE->", "STARTED", 1);
}

void PlayMode::EnterFullScreen()
{
	if(!isFullScreen && isPlayMode)
	   glutFullScreen();

	isFullScreen = GL_TRUE;

	Log("GAME-MODE->", "FULL-SCREEN", 1);
}

void PlayMode::LeaveFullScreen()
{
	if(isFullScreen && isPlayMode)
	   glutLeaveFullScreen();

	isFullScreen = GL_FALSE;

	Log("GAME-MODE->", "WINDOWED", 1);
}

void PlayMode::Exit(bool *Gizmos) 
{
	*Gizmos = true;
	isPlayMode = GL_FALSE;

	glutSetWindowTitle("Effect Editor - Edit Mode");

	Log("GAME-MODE->", "Exit", 1);
}
