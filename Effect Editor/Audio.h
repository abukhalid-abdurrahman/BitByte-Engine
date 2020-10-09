#ifndef AUDIO_H
#define AUDIO_H

using namespace irrklang;

#pragma comment(lib, "irrKlang.lib")

class Audio
{
private:
	const char *FileName;
	ISoundEngine* AudioEngine;
public:
	Audio(void);
	~Audio(void);
	void LoadAudio(const char *aAudioFileName);
	void Play2D(bool isActive, bool isLoop, float Volume);
	void Istantiate(bool isActive, bool Gizmos);
	void Clear();
};
#endif
