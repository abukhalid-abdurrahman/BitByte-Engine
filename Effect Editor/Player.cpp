#include "stdafx.h"
#include "Player.h"

Player::Player(void)
{
}


Player::~Player(void)
{
}

void Player::Setup(CAMERA PlayerCamera)
{
	PlayerCamera.Update();
	PlayerCamera.Apply();
}

void Player::Istantiate(CAMERA PlayerCamera,  bool Gizmos)
{
	glPushMatrix();
	glTranslatef(PlayerCamera.Movement_x, PlayerCamera.Movement_y, PlayerCamera.Movement_z);
	if(Gizmos)
	{
		glDisable(GL_LIGHTING);
		glBegin(GL_LINE_STRIP);
		glColor3f(1, 0, 0);
		glVertex3f(0.0f, 0.0f, 0.0f);
		glVertex3f(5, 0.0f, 0.0f);
		glColor3f(0, 1, 0);
		glVertex3f(0.0f, 0.0f, 0.0f);
		glVertex3f(0.0f, 5, 0.0f);
		glColor3f(0, 0, 1);
		glVertex3f(0.0f, 0.0f, 0.0f);
		glVertex3f(0.0f, 0.0f, 5);
		glEnd();
		glEnable(GL_LIGHTING);

		glScalef(1, 2, 1);
		glutSolidCube(1);
	}
	glPopMatrix();
}

void Player::SetMouse(CAMERA PlayerCamera, int X, int Y)
{
	PlayerCamera.Delta_x = float((Y) - Play_Mode.SCREEN_HEIGHT() * 2)/0.2;
	PlayerCamera.Delta_y = float((X) - Play_Mode.SCREEN_WIDTH() * 2)/0.2;
}

void Player::SetKeyboard(CAMERA PlayerCamera, int Key)
{
	PlayerMovementSpeed = 1;

	switch (Key)
	{
	  case GLUT_KEY_F1:
		  PlayerCamera.Movement_x += PlayerMovementSpeed;
		break;
	  case GLUT_KEY_F2:
	 	  PlayerCamera.Movement_x -= PlayerMovementSpeed;
		break;
	  case GLUT_KEY_F3:
		  PlayerCamera.Movement_z -= PlayerMovementSpeed;
		break;
	 case GLUT_KEY_F4:
		  PlayerCamera.Movement_z += PlayerMovementSpeed;
		break;
	}
}