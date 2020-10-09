#ifndef ShaderH
#define ShaderH

#include <string>
#include <fstream>
#include <sstream>
#include <iostream>

#pragma warning(disable : 4996)

using namespace std;


class Shader
{
public:
	~Shader(void);

	GLuint Program;

	Shader(void);

	void LoadShader(const GLchar* vertexShader,  const GLchar* fragmentShader);
	void Use();
};
#endif

