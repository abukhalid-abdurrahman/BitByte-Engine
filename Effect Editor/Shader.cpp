//////////////////////////////////
//Разработчик: Faridun Berdiev
//****************************
//Имя Файл: Shader.cpp
//******************
//Версия: v0.1.8
//************
//Файл отвечающий за Шейдеры
//*****************************************
//////////////////////////////////

#include "stdafx.h"
#include "Shader.h"


using namespace std;

Shader::Shader(void)
{
}	
Shader::~Shader(void)
{
}

void Shader::LoadShader(const GLchar* vertexShader, const GLchar* fragmentShader)
{
	string vertexCode;
	string fragmentCode;
	ifstream vsFile;
	ifstream fsFile;

	vsFile.exceptions(ifstream::failbit | ifstream::badbit);
	fsFile.exceptions(ifstream::failbit | ifstream::badbit);

	try
	{
		vsFile.open(vertexShader);
		fsFile.open(fragmentShader);
		stringstream vsStream, fsStream;

		vsStream << vsFile.rdbuf();
		fsStream << fsFile.rdbuf();

		vsFile.close();
		fsFile.close();

		vertexCode = vsStream.str();
		fragmentCode = fsStream.str();
	}
	catch(ifstream::failure ex)
	{
		Log("SHADER->" ,"BAD SHADER FILE", 1);
	}

	const GLchar* vShaderCode = vertexCode.c_str();
	const GLchar* fShaderCode = fragmentCode.c_str();

	GLuint vertex, fragment;
	GLint success;
	GLchar infoLog[512];

	vertex = glCreateShader(GL_VERTEX_SHADER);
	glShaderSource(vertex, 1, &vShaderCode, NULL);
	glCompileShader(vertex);

	glGetShaderiv(vertex, GL_COMPILE_STATUS, &success);

	if(!success)
	{
		glGetShaderInfoLog(vertex, 512, NULL, infoLog);
		Log("SHADER->" ,"VERTEX SHADER COMPILATION FAILED", 1);
	}

	fragment = glCreateShader(GL_VERTEX_SHADER);
	glShaderSource(fragment, 1, &fShaderCode, NULL);
	glCompileShader(fragment);

	glGetShaderiv(fragment, GL_COMPILE_STATUS, &success);

	if(!success)
	{
		glGetShaderInfoLog(fragment, 512, NULL, infoLog);
		Log("SHADER->" ,"FRAGMENT SHADER COMPILATION FAILED", 1);
	}

	this->Program = glCreateProgram();
	glAttachShader(this->Program, vertex);
	glAttachShader(this->Program, fragment);
	glLinkProgram(this->Program);

	glGetProgramiv(this->Program, GL_LINK_STATUS, &success);
	if(!success)
	{
		glGetProgramInfoLog(this->Program, 512, NULL, infoLog);
		Log("SHADER->" ,"LINKING FAILED", 1);
	}

	glDeleteShader(vertex);
	glDeleteShader(fragment);
}

void Shader::Use()
{
	glUseProgram(this->Program);
}