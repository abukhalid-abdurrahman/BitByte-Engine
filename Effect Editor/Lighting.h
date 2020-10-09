#ifndef LightingH
#define LightingH

#include "glm\glm\glm.hpp"

class Lighting
{
public:
	Lighting(void);
	~Lighting(void);
	void SetMaterial(GLfloat Color[4]);
	void LightInit(bool Enabled, bool Normalize);
	void AmbientLight(bool Enabled, GLfloat AmbientColor[]);
	void PointLight(GLenum lNum, bool Enabled, bool Gizmos, 
						  glm::vec3 Position,
						  GLfloat PointLightColor[], 
						  float LRadius);

	void SpotLight(GLenum lNum, bool Enabled, bool Gizmos,
						 glm::vec3 Position,
						 GLfloat SpotDirection[],
						 GLfloat SpotLightColor[]);

	void DirectionalLight(GLenum lNum, bool Enabled,
		GLfloat LDirection[],
		GLfloat DirectionalLightColor[]);
};
#endif

