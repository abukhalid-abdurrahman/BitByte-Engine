#ifndef TextureH
#define TextureH

#include <assimp/cimport.h>
#include <assimp/scene.h>
#include <assimp/postprocess.h>

class Texture
{
public:
	Texture(void);
	~Texture(void);

	string GetBasePath(const string& Path);
	
	
	bool ai_LoadTexture(GLfloat TexParams, 
		const aiScene* _mScene, 
		const string ModelPath);

	map<string, GLuint*> TextureIDMap;
	
	bool LoadTGA(GLfloat TexParams, 
		char TexName[256]);

    GLubyte* ImageData;
    GLuint  tBpp;                                                     
    GLuint  tWidth;                                                 
    GLuint  tHeight;                                     
    GLuint  tTexID, *tTexIDS;  
};
#endif

