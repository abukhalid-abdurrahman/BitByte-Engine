#ifndef GraphicsH
#define GraphicsH

class Graphics
{
private:
	void RenderEnvironment(bool Gizmos);
	void RenderGrid(bool Gizmos);
	void InitLights(bool Enabled, GLfloat AmbientColor[]);

public:
	Graphics(void);
	~Graphics(void);

	void Init(bool lEnabled, 
		bool nNormal);

	void RenderScene(bool Gizmos, 
		bool eLight,
		GLfloat AmbientColor[],
		GLfloat BackgroundColor1[3],
		GLfloat BackgroundColor2[3],
		bool dSky, 
		bool bBak, 
		Texture *tTexture, CAMERA* cmCam, 
		int Width, int Height,
		void (* View)(int X, int Y));
};
#endif

