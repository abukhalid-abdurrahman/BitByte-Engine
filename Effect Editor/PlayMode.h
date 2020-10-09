#ifndef PLAYMODE_H
#define PLAYMODE_H
class PlayMode
{
public:
	int Frame;
	long Time, TimeBase;
	GLboolean isFullScreen;
	GLboolean isPlayMode;
public:
	char FPS[60];
	char GS[80];
	void GetMode();
	void FramePerSecond();
public:
	int SCREEN_WIDTH();
	int SCREEN_HEIGHT();
public:
	PlayMode(void);
	~PlayMode(void);

	void Play(bool *Gizmos);
	void Exit(bool *Gizmos);
	void EnterFullScreen();
	void LeaveFullScreen();
	void RenderStates();
};
#endif

