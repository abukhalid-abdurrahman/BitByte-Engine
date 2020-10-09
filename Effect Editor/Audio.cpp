//////////////////////////////////
//Разработчик: Faridun Berdiev
//****************************
//Имя Файл: Audio.cpp
//******************
//Версия: v0.1.8
//************
//Проигрование звуков (irrKlang)
//*****************************************
//////////////////////////////////

#include "stdafx.h"
#include "Audio.h"

Audio::Audio(void)
{
}

Audio::~Audio(void)
{
}


ISoundEngine* AudioEngine = 0;

void Audio::Istantiate(bool isActive, bool Gizmos)
{
	if(isActive)
	{
		if(Gizmos)
		{
			glDisable(GL_LIGHTING);
		    glPushMatrix();
		    glEnable(GL_BLEND);
		    glBlendFunc(GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA);
		    glColor4f(1.0f, 1.0f, 1.0f, 0.3f);
		    glutSolidSphere(30, 8, 8);
		    glDisable(GL_BLEND);
			glutWireSphere(30, 8, 8);
		    glPopMatrix();
	        glEnable(GL_LIGHTING);
		}
	}
}

void Audio::LoadAudio(const char * aAudioFileName)
{
	FileName = aAudioFileName;
}

void Audio::Play2D(bool isActive, bool isLoop, float Volume)
{
	AudioEngine = createIrrKlangDevice();

	if(!AudioEngine)
	{
		Log("LOAD-AUDIO->", "CAN'T LOAD AUDIO", 1);
		MessageDialogDefault("Fatal Error!!!", "Can't Load Audio\n", MB_ICONERROR | MB_OK, 1);
		return;
	}

	if(isActive)
	{
		AudioEngine->setSoundVolume((ik_f32)Volume);
	    AudioEngine->play2D(FileName, isLoop);
	}
}

void Audio::Clear()
{
	AudioEngine->drop();
}