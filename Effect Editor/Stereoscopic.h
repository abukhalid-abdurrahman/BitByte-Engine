#ifndef STEREOSCOPIC_H
#define STEREOSCOPIC_H
class Stereoscopic
{
public:
	Stereoscopic(void);
	~Stereoscopic(void);
public:
	void InitStereoscopic(void(*RenderFunction)(void), GLfloat EyeOffset);
};
#endif

