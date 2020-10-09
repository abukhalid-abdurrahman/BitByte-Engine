#ifndef PLAYER_H
#define PLAYER_H
class Player
{
protected:
	PlayMode Play_Mode;
	float PlayerMovementSpeed;
public:
	void Setup(CAMERA PlayerCamera);
	void SetMouse(CAMERA PlayerCamera, int X, int Y);
	void SetKeyboard(CAMERA PlayerCamera, int Key);
	void Istantiate(CAMERA PlayerCamera, bool Gizmos);
public:
	Player(void);
	~Player(void);
};
#endif

