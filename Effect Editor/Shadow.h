#ifndef ShadowH
#define ShadowH
class Shadow
{
public:
	Shadow(void);
	~Shadow(void);
	void InverseMatrix(float dst[16], float src[16]);
	GLcharARB* LoadShaderSource(const char *filename);
	GLhandleARB CreateShaderProgram(const char *vert_filename, const char *frag_filename);
};
#endif ShadowH

