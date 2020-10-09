#include "stdafx.h"
#include "Shadow.h"

const float PI = 3.14f;
const float DEG2RAD = PI / 180.0f;
GLuint texDepth = 0;
GLuint texDepth2 = 0;
const int texDepthSizeX = 1024;
const int texDepthSizeY = 1024;

GLuint rbDepth = 0;
GLuint fbDepth = 0;
GLuint fbDepth2 = 0;

int currentShader = 0;
GLhandleARB shaderDepth = 0;
GLhandleARB shaderShadowTex2D = 0;
GLhandleARB shaderShadowShad2D = 0;
GLuint uniformShadowTex2D_shadowMap = 0;
GLuint uniformShadowTex2D_lightMatrix = 0;
GLuint uniformShadowTex2D_lightPos = 0;
GLuint uniformShadowTex2D_lightDir = 0;
GLuint uniformShadowShad2D_shadowMap = 0;
GLuint uniformShadowShad2D_lightMatrix = 0;
GLuint uniformShadowShad2D_lightPos = 0;
GLuint uniformShadowShad2D_lightDir = 0;

float cameraProjectionMatrix[16];
float cameraModelViewMatrix[16];
float cameraInverseModelViewMatrix[16];
float lightProjectionMatrix[16];
float lightModelViewMatrix[16];
float lightMatrix[16];

struct Vertex
{
	float pos[3];
	float normal[3];
};

Vertex *verts = NULL;
GLuint *inds = NULL;
int icount = 0;
int vcount = 0;

float modelBBoxMin[3];
float modelBBoxMax[3];
float modelCenter[3];

GLuint vboId = 0;
GLuint eboId = 0;

Shadow::Shadow(void)
{
}


Shadow::~Shadow(void)
{
}


void Shadow::InverseMatrix(float dst[16], float src[16])
{
	dst[0] = src[0];
	dst[1] = src[4];
	dst[2] = src[8];
	dst[3] = 0.0;
	dst[4] = src[1];
	dst[5] = src[5];
	dst[6]  = src[9];
	dst[7] = 0.0;
	dst[8] = src[2];
	dst[9] = src[6];
	dst[10] = src[10];
	dst[11] = 0.0;
	dst[12] = -(src[12] * src[0]) - (src[13] * src[1]) - (src[14] * src[2]);
	dst[13] = -(src[12] * src[4]) - (src[13] * src[5]) - (src[14] * src[6]);
	dst[14] = -(src[12] * src[8]) - (src[13] * src[9]) - (src[14] * src[10]);
	dst[15] = 1.0;
}

GLcharARB* Shadow::LoadShaderSource(const char *filename)
{
	FILE *file;
	if (fopen_s(&file, filename, "r") != 0)
	{
		std::cout << "Can't open shader file" << std::endl;
		std::cout << std::endl;
		return NULL;
	}
	struct _stat filestats;
	if (_stat(filename, &filestats))
	{
		std::cout << "Can't get shader file information!" << std::endl;
		std::cout << std::endl;
		return NULL;
	}
	GLcharARB *shaderSource = new char[filestats.st_size + 1];
	int bytes = (int)fread(shaderSource, 1, filestats.st_size, file);
	shaderSource[bytes] = 0;
	fclose(file);
	return shaderSource;
}


GLhandleARB Shadow::CreateShaderProgram(const char *vert_filename, const char *frag_filename)
{
	GLcharARB *shaderSource;
	GLhandleARB objShader;
	GLint result;
	GLsizei len;
	GLcharARB *infoLog;

	GLhandleARB shaderProgram = glCreateProgramObjectARB();

	shaderSource = LoadShaderSource(vert_filename);
	if (shaderSource == NULL)
	{
		glDeleteObjectARB(shaderProgram);
		return 0;
	}
	objShader = glCreateShaderObjectARB(GL_VERTEX_SHADER_ARB);
	glShaderSourceARB(objShader, 1, (const GLcharARB **)&shaderSource, NULL);
	delete[] shaderSource;

	glCompileShaderARB(objShader);
	result = GL_FALSE;
	glGetObjectParameterivARB(objShader, GL_OBJECT_COMPILE_STATUS_ARB, &result);

	glGetObjectParameterivARB(objShader, GL_OBJECT_INFO_LOG_LENGTH_ARB, &len);
	if (len > 1)
	{
		infoLog = (GLcharARB *)malloc(len * sizeof(GLcharARB));
		glGetInfoLogARB(objShader, len, NULL, infoLog);
		std::cout << "Shader Log Program: '" << vert_filename << "':" << std::endl << infoLog << std::endl;
		free((void *)infoLog);
	}

	if (result != GL_TRUE)
	{
		std::cout << "Error with compiling shader: " << vert_filename << "!" << std::endl;
		std::cout << std::endl;
		glDeleteObjectARB(shaderProgram);
		return 0;
	}

	glAttachObjectARB(shaderProgram, objShader);

	glDeleteObjectARB(objShader);


	shaderSource = LoadShaderSource(frag_filename);
	if (shaderSource == NULL)
	{
		glDeleteObjectARB(shaderProgram);
		return 0;
	}
	objShader = glCreateShaderObjectARB(GL_FRAGMENT_SHADER_ARB);
	glShaderSourceARB(objShader, 1, (const GLcharARB **)&shaderSource, NULL);
	delete[] shaderSource;

	glCompileShaderARB(objShader);
	result = GL_FALSE;
	glGetObjectParameterivARB(objShader, GL_OBJECT_COMPILE_STATUS_ARB, &result);

	glGetObjectParameterivARB(objShader, GL_OBJECT_INFO_LOG_LENGTH_ARB, &len);
	if (len > 1)
	{
		infoLog = (GLcharARB *)malloc(len * sizeof(GLcharARB));
		glGetInfoLogARB(objShader, len, NULL, infoLog);
		std::cout << "Shader Log Program: " << frag_filename << ":" << std::endl << infoLog << std::endl;
		free((void *)infoLog);
	}

	if (result != GL_TRUE)
	{
		std::cout << "Error with compiling shader: " << frag_filename << "'!" << std::endl;
		std::cout << std::endl;
		glDeleteObjectARB(shaderProgram);
		return 0;
	}

	glAttachObjectARB(shaderProgram, objShader);

	glDeleteObjectARB(objShader);


	result = GL_FALSE;
	glLinkProgramARB(shaderProgram);
	glGetObjectParameterivARB(shaderProgram, GL_OBJECT_LINK_STATUS_ARB, &result);

	glGetObjectParameterivARB(shaderProgram, GL_OBJECT_INFO_LOG_LENGTH_ARB, &len);
	if (len > 1)
	{
		infoLog = (GLcharARB *)malloc(len * sizeof(GLcharARB));
		glGetInfoLogARB(shaderProgram, len, NULL, infoLog);
		std::cout << "Shader Log Program: " << std::endl << infoLog << std::endl;
		free((void *)infoLog);
	}

	if (result != GL_TRUE)
	{
		std::cout << "Error with compiling shader: " << vert_filename << "', '" << frag_filename << "!" << std::endl;
		std::cout << std::endl;
		glDeleteObjectARB(shaderProgram);
		return 0;
	}
	return shaderProgram;
}

