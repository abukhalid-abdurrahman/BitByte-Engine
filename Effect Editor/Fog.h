#ifndef FogH
#define FogH
class Fog
{
public:
	Fog(void);
	~Fog(void);
	void FogInit(bool Enabled, float FogColor[4], float FogStart, float FogEnd);
};
#endif

