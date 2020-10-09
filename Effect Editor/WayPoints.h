#ifndef WAYPOINTS_H
#define WAYPOINTS_H
class WayPoints
{
public:
	struct Coordinates
	{
		GLfloat X, Y, Z;
	};
public:
	void PlayWayPointAnimation(Coordinates Coor, GLfloat Time, GLfloat Speed, GLboolean *Stop);
	void TranslateToPosition(Coordinates Coor);
public:
	WayPoints(void);
	~WayPoints(void);
};
#endif

