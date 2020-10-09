//////////////////////////////////
//Разработчик: Faridun Berdiev
//****************************
//Имя Файл: Effect Editor.cpp
//******************
//Версия: v0.1.8
//************
//Главный файл Faridun's Game Engine : Effect Editor
//*****************************************
//////////////////////////////////

#include "stdafx.h"

#pragma warning(disable : 4996)

using namespace std;

string WindowTitle = "Effect Editor - Edit Mode";

GLfloat  Speed     = 0.4f,
	     AmbientCOLOR[3],
	     BackgroundColor1[3],
	     BackgroundColor2[3];


int Height   = 750, 
	Width    = 1200,
	CurCamera = 0,
	NumCam    = 1;

bool FreeCamera = false,
	Gizmos      = true,
	bLighting   = true,
	bBackground = true,
	bSkybox     = false,
	efFog       = false,
	AudioAdded  = false,
	MSAA        = false;

const float PI = 3.14f;

float fogColor[4] = {0.9f, 0.9f, 0.9f, 1};

CAMERA *cam = new CAMERA[NumCam + 1];

Fog fFog;
Graphics gfx;
Skybox sky;
Texture *TextureTGA = new Texture[8];
PlayMode P_Mode;
TwBar *UI, *Hierarchy;

int CubesCount            = 0,
	SpheresCount          = 0,
	PlanesCount           = 0,
	QuadsCount            = 0,
	TextsCount            = 0,
	PointLightCount       = 0,
	SpotLightCount        = 0,
	DirectionalLightCount = 0;

const int Limit = 500;

GameObject       c_Object[Limit];
GameObject       s_Object[Limit];
GameObject       p_Object[Limit];
GameObject       q_Object[Limit];
GameObject       m_Object[Limit];
PointLight       p_Light[Limit];
SpotLight        s_Light[Limit];
DirectionalLight d_Light[Limit];
AudioSource      a_Source[Limit];
Lighting         LightableObjects[Limit], Mat;

vector<Model> mModel;
vector<Audio> aAudio;

GLboolean FILLMODE = GL_TRUE, 
	      LINEMODE = GL_FALSE, 
	      POINTMODE = GL_FALSE;

Stereoscopic Stereo;

void LoadAudio();
void Terminate();

GLboolean CheckOpenGLError()
{
	GLboolean Flag = GL_TRUE;

	for(;;)
	{
		GLenum GL_ERROR = glGetError();
		if(GL_ERROR == GL_NO_ERROR)
			Flag = GL_TRUE;

		cout << "GL-MESSAGE->" << gluErrorString(GL_ERROR) << endl;

		Flag = GL_FALSE;
		GL_ERROR = glGetError();
	}

	return Flag;
}

void SetCamera(CAMERA *camera)
{
    int Temp;

    for(Temp = 0; Temp < NumCam; Temp++)
        camera[Temp].Reset();
}

void Projection(int W, int H)
{
    glViewport(0, 0, W, H);
	glScissor(0, 0, W, H);
    glMatrixMode(GL_PROJECTION);
    glLoadIdentity();
	gluPerspective(60.0, (float)W / (float)H, 5.0, 2000.0);
}

void View(int W, int H)
{
    Projection(W, H);
    glMatrixMode(GL_MODELVIEW);
    glLoadIdentity();
}

void ModelHierarchy()
{
    TwStructMember ModelMembers[] = 
	{
		{"Active",         TW_TYPE_BOOLCPP, offsetof(GameObject, isActive),        " readonly=false "},
		{"Blended Color",  TW_TYPE_BOOLCPP, offsetof(GameObject, isColorBlended),  " readonly=false "},
		{"Material Color", TW_TYPE_COLOR4F, offsetof(GameObject, MaterialColor),   " readonly=false "},
		{"Position X",     TW_TYPE_FLOAT,   offsetof(GameObject, Position.x),      " readonly=false "},
		{"Position Y",     TW_TYPE_FLOAT,   offsetof(GameObject, Position.y),      " readonly=false "},
		{"Position Z",     TW_TYPE_FLOAT,   offsetof(GameObject, Position.z),      " readonly=false "},
		{"Rotation Angle", TW_TYPE_FLOAT,   offsetof(GameObject, RotAngle),        " readonly=false "},
		{"Rotation X",     TW_TYPE_FLOAT,   offsetof(GameObject, RotX),            " readonly=false "},
		{"Rotation Y",     TW_TYPE_FLOAT,   offsetof(GameObject, RotY),            " readonly=false "},
		{"Rotation Z",     TW_TYPE_FLOAT,   offsetof(GameObject, RotZ),            " readonly=false "},
		{"Scale X",        TW_TYPE_FLOAT,   offsetof(GameObject, Scale.x),         " readonly=false "},
		{"Scale Y",        TW_TYPE_FLOAT,   offsetof(GameObject, Scale.y),         " readonly=false "},
		{"Scale Z",        TW_TYPE_FLOAT,   offsetof(GameObject, Scale.z),         " readonly=false "}
	};
    TwType m_Objects = TwDefineStruct("HierarchyM", ModelMembers, 13, sizeof(GameObject), NULL, NULL);
	
	for(int i = 0; i < 1; i++)
	{
		char def[256];
        _snprintf(def, sizeof(def), "group='Objects Settings' label='Model #%d' ", i + 1, i + 1);
		TwAddVarRW(Hierarchy, m_Object[i].Name, m_Objects, &m_Object[i], def);
	}
}

void ObjectsHierarchy()
{
	TwStructMember CubeMembers[] = 
	{
		{"Active",         TW_TYPE_BOOLCPP, offsetof(GameObject, isActive),        " readonly=false "},
		{"Blended Color",  TW_TYPE_BOOLCPP, offsetof(GameObject, isColorBlended),  " readonly=false "},
		{"Material Color", TW_TYPE_COLOR4F, offsetof(GameObject, MaterialColor),   " readonly=false "},
		{"Position X",     TW_TYPE_FLOAT,   offsetof(GameObject, Position.x),      " readonly=false "},
		{"Position Y",     TW_TYPE_FLOAT,   offsetof(GameObject, Position.y),      " readonly=false "},
		{"Position Z",     TW_TYPE_FLOAT,   offsetof(GameObject, Position.z),      " readonly=false "},
		{"Rotation Angle", TW_TYPE_FLOAT,   offsetof(GameObject, RotAngle),        " readonly=false "},
		{"Rotation X",     TW_TYPE_FLOAT,   offsetof(GameObject, RotX),            " readonly=false "},
		{"Rotation Y",     TW_TYPE_FLOAT,   offsetof(GameObject, RotY),            " readonly=false "},
		{"Rotation Z",     TW_TYPE_FLOAT,   offsetof(GameObject, RotZ),            " readonly=false "},
		{"Scale X",        TW_TYPE_FLOAT,   offsetof(GameObject, Scale.x),         " readonly=false "},
		{"Scale Y",        TW_TYPE_FLOAT,   offsetof(GameObject, Scale.y),         " readonly=false "},
		{"Scale Z",        TW_TYPE_FLOAT,   offsetof(GameObject, Scale.z),         " readonly=false "}
	};

	TwStructMember SphereMembers[] = 
	{
		{"Active",         TW_TYPE_BOOLCPP, offsetof(GameObject, isActive),        " readonly=false "},
		{"Blended Color",  TW_TYPE_BOOLCPP, offsetof(GameObject, isColorBlended),  " readonly=false "},
		{"Material Color", TW_TYPE_COLOR4F, offsetof(GameObject, MaterialColor),   " readonly=false "},
		{"Position X",     TW_TYPE_FLOAT,   offsetof(GameObject, Position.x),      " readonly=false "},
		{"Position Y",     TW_TYPE_FLOAT,   offsetof(GameObject, Position.y),      " readonly=false "},
		{"Position Z",     TW_TYPE_FLOAT,   offsetof(GameObject, Position.z),      " readonly=false "},
		{"Rotation Angle", TW_TYPE_FLOAT,   offsetof(GameObject, RotAngle),        " readonly=false "},
		{"Rotation X",     TW_TYPE_FLOAT,   offsetof(GameObject, RotX),            " readonly=false "},
		{"Rotation Y",     TW_TYPE_FLOAT,   offsetof(GameObject, RotY),            " readonly=false "},
		{"Rotation Z",     TW_TYPE_FLOAT,   offsetof(GameObject, RotZ),            " readonly=false "},
		{"Scale X",        TW_TYPE_FLOAT,   offsetof(GameObject, Scale.x),         " readonly=false "},
		{"Scale Y",        TW_TYPE_FLOAT,   offsetof(GameObject, Scale.y),         " readonly=false "},
		{"Scale Z",        TW_TYPE_FLOAT,   offsetof(GameObject, Scale.z),         " readonly=false "}
	};

	TwStructMember PlaneMembers[] = 
	{
		{"Active",         TW_TYPE_BOOLCPP, offsetof(GameObject, isActive),        " readonly=false "},
		{"Blended Color",  TW_TYPE_BOOLCPP, offsetof(GameObject, isColorBlended),  " readonly=false "},
		{"Material Color", TW_TYPE_COLOR4F, offsetof(GameObject, MaterialColor),   " readonly=false "},
		{"Position X",     TW_TYPE_FLOAT,   offsetof(GameObject, Position.x),      " readonly=false "},
		{"Position Y",     TW_TYPE_FLOAT,   offsetof(GameObject, Position.y),      " readonly=false "},
		{"Position Z",     TW_TYPE_FLOAT,   offsetof(GameObject, Position.z),      " readonly=false "},
		{"Rotation Angle", TW_TYPE_FLOAT,   offsetof(GameObject, RotAngle),        " readonly=false "},
		{"Rotation X",     TW_TYPE_FLOAT,   offsetof(GameObject, RotX),            " readonly=false "},
		{"Rotation Y",     TW_TYPE_FLOAT,   offsetof(GameObject, RotY),            " readonly=false "},
		{"Rotation Z",     TW_TYPE_FLOAT,   offsetof(GameObject, RotZ),            " readonly=false "},
		{"Scale X",        TW_TYPE_FLOAT,   offsetof(GameObject, Scale.x),         " readonly=false "},
		{"Scale Y",        TW_TYPE_FLOAT,   offsetof(GameObject, Scale.y),         " readonly=false "},
		{"Scale Z",        TW_TYPE_FLOAT,   offsetof(GameObject, Scale.z),         " readonly=false "}
	};

	TwStructMember QuadMembers[] = 
	{
		{"Active",         TW_TYPE_BOOLCPP, offsetof(GameObject, isActive),        " readonly=false "},
		{"Blended Color",  TW_TYPE_BOOLCPP, offsetof(GameObject, isColorBlended),  " readonly=false "},
		{"Material Color", TW_TYPE_COLOR4F, offsetof(GameObject, MaterialColor),   " readonly=false "},
		{"Position X",     TW_TYPE_FLOAT,   offsetof(GameObject, Position.x),      " readonly=false "},
		{"Position Y",     TW_TYPE_FLOAT,   offsetof(GameObject, Position.y),      " readonly=false "},
		{"Position Z",     TW_TYPE_FLOAT,   offsetof(GameObject, Position.z),      " readonly=false "},
		{"Rotation Angle", TW_TYPE_FLOAT,   offsetof(GameObject, RotAngle),        " readonly=false "},
		{"Rotation X",     TW_TYPE_FLOAT,   offsetof(GameObject, RotX),            " readonly=false "},
		{"Rotation Y",     TW_TYPE_FLOAT,   offsetof(GameObject, RotY),            " readonly=false "},
		{"Rotation Z",     TW_TYPE_FLOAT,   offsetof(GameObject, RotZ),            " readonly=false "},
		{"Scale X",        TW_TYPE_FLOAT,   offsetof(GameObject, Scale.x),         " readonly=false "},
		{"Scale Y",        TW_TYPE_FLOAT,   offsetof(GameObject, Scale.y),         " readonly=false "},
		{"Scale Z",        TW_TYPE_FLOAT,   offsetof(GameObject, Scale.z),         " readonly=false "}
	};

	TwStructMember PointLightObjectMembers[] = 
	{
		{"Active",         TW_TYPE_BOOLCPP, offsetof(PointLight, isActive),        " readonly=false "},
		{"Color",          TW_TYPE_COLOR3F, offsetof(PointLight, PointLightColor), " readonly=false "},
		{"Radius",         TW_TYPE_FLOAT,   offsetof(PointLight, PointLightRadius)," readonly=false "},
		{"Position X",     TW_TYPE_FLOAT,   offsetof(PointLight, Position.x),      " readonly=false "},
		{"Position Y",     TW_TYPE_FLOAT,   offsetof(PointLight, Position.y),      " readonly=false "},
		{"Position Z",     TW_TYPE_FLOAT,   offsetof(PointLight, Position.z),      " readonly=false "}
	};

	TwStructMember SpotLightObjectMembers[] = 
	{
		{"Active",         TW_TYPE_BOOLCPP, offsetof(SpotLight, isActive),        " readonly=false "},
		{"Color",          TW_TYPE_COLOR3F, offsetof(SpotLight, SpotLightColor),  " readonly=false "},
		{"Spot Direction", TW_TYPE_DIR3F,   offsetof(SpotLight, SpotDirection),   " readonly=false "},
		{"Position X",     TW_TYPE_FLOAT,   offsetof(SpotLight, Position.x),      " readonly=false "},
		{"Position Y",     TW_TYPE_FLOAT,   offsetof(SpotLight, Position.y),      " readonly=false "},
		{"Position Z",     TW_TYPE_FLOAT,   offsetof(SpotLight, Position.z),      " readonly=false "}
	};

	TwStructMember DirectionalLightObjectMembers[] = 
	{
		{"Active",         TW_TYPE_BOOLCPP, offsetof(DirectionalLight, isActive),               " readonly=false "},
		{"Color",          TW_TYPE_COLOR3F, offsetof(DirectionalLight, DirectionalLightColor),  " readonly=false "},
		{"Direction",      TW_TYPE_DIR3F,   offsetof(DirectionalLight, LightDirection),         " readonly=false "}
	};
	
	TwType c_Objects = TwDefineStruct("HierarchyC", CubeMembers,            13, sizeof(GameObject),       NULL, NULL);
	TwType s_Objects = TwDefineStruct("HierarchyS", SphereMembers,          13, sizeof(GameObject),       NULL, NULL);
	TwType p_Objects = TwDefineStruct("HierarchyP", PlaneMembers,           13, sizeof(GameObject),       NULL, NULL);
	TwType q_Objects = TwDefineStruct("HierarchyQ", QuadMembers,           13, sizeof(GameObject),       NULL, NULL);
	TwType pl_Objects = TwDefineStruct("HierarchyPL", PointLightObjectMembers, 6, sizeof(PointLight),       NULL, NULL);
	TwType sl_Objects = TwDefineStruct("HierarchySL", SpotLightObjectMembers, 6, sizeof(SpotLight),        NULL, NULL);
	TwType d_Objects = TwDefineStruct("HierarchyD", DirectionalLightObjectMembers, 3, sizeof(DirectionalLight), NULL, NULL);
	
	for(int i = 0; i < CubesCount; i++)
	{
		char def[256];
        _snprintf(def, sizeof(def), "group='Objects Settings' label='Cube #%d' ", i + 1, i + 1);
		TwAddVarRW(Hierarchy, c_Object[i].Name, c_Objects, &c_Object[i], def);
	}

	for(int i = 0; i < SpheresCount; i++)
	{
		char def[256];
        _snprintf(def, sizeof(def), "group='Objects Settings' label='Sphere #%d' ", i + 1, i + 1);
		TwAddVarRW(Hierarchy, s_Object[i].Name, s_Objects, &s_Object[i], def);
	}

	for(int i = 0; i < PlanesCount; i++)
	{
		char def[256];
        _snprintf(def, sizeof(def), "group='Objects Settings' label='Plane #%d' ", i + 1, i + 1);
		TwAddVarRW(Hierarchy, p_Object[i].Name, p_Objects, &p_Object[i], def);
	}

	for(int i = 0; i < QuadsCount; i++)
	{
		char def[256];
        _snprintf(def, sizeof(def), "group='Objects Settings' label='Quad #%d' ", i + 1, i + 1);
		TwAddVarRW(Hierarchy, q_Object[i].Name, q_Objects, &q_Object[i], def);
	}

	for(int i = 0; i < PointLightCount; i++)
	{
		char def[256];
        _snprintf(def, sizeof(def), "group='Objects Settings' label='Point Light #%d' ", i + 1, i + 1);
		TwAddVarRW(Hierarchy, p_Light[i].Name, pl_Objects, &p_Light[i], def);
	}

	for(int i = 0; i < SpotLightCount; i++)
	{
		char def[256];
        _snprintf(def, sizeof(def), "group='Objects Settings' label='Spot Light #%d' ", i + 1, i + 1);
		TwAddVarRW(Hierarchy, s_Light[i].Name, sl_Objects, &s_Light[i], def);
	}

	for(int i = 0; i < DirectionalLightCount; i++)
	{
		char def[256];
        _snprintf(def, sizeof(def), "group='Objects Settings' label='Directional Light #%d' ", i + 1, i + 1);
		TwAddVarRW(Hierarchy, d_Light[i].Name, d_Objects, &d_Light[i], def);
	}

}

void Init(bool ResetCam)
{
	View(Width, Height);
	if(ResetCam)
	  SetCamera(cam);
	gfx.Init(bLighting, bLighting);
}

void CubeCreator()
{
	for(int i = 0; i < CubesCount; i++)
	{
		c_Object[i].isActive = true;
		c_Object[i].isColorBlended = true;
		c_Object[i].MaterialColor[0] = 1;
		c_Object[i].MaterialColor[1] = 1;
		c_Object[i].MaterialColor[2] = 1;
		c_Object[i].MaterialColor[3] = 1;

		c_Object[i].Position.x = 0;
		c_Object[i].Position.y = 0;
		c_Object[i].Position.z = 0;

		c_Object[i].RotAngle = 0;
		c_Object[i].RotX = 0;
		c_Object[i].RotY = 0;
		c_Object[i].RotZ = 0;

		c_Object[i].Scale.x = 1;
		c_Object[i].Scale.y = 1;
		c_Object[i].Scale.z = 1;
	}
}

void SphereCreator()
{
	for(int i = 0; i < SpheresCount; i++)
	{
		s_Object[i].isActive = true;
		s_Object[i].isColorBlended = true;
		s_Object[i].MaterialColor[0] = 1;
		s_Object[i].MaterialColor[1] = 1;
		s_Object[i].MaterialColor[2] = 1;
		s_Object[i].MaterialColor[3] = 1;

		s_Object[i].Position.x = 0;
		s_Object[i].Position.y = 0;
		s_Object[i].Position.z = 0;

		s_Object[i].RotAngle = 0;
		s_Object[i].RotX = 0;
		s_Object[i].RotY = 0;
		s_Object[i].RotZ = 0;

		s_Object[i].Scale.x = 1;
		s_Object[i].Scale.y = 1;
		s_Object[i].Scale.z = 1;
	}
}

void PlaneCreator()
{
	for(int i = 0; i < SpheresCount; i++)
	{
		p_Object[i].isActive = true;
		p_Object[i].isColorBlended = true;
		p_Object[i].MaterialColor[0] = 1;
		p_Object[i].MaterialColor[1] = 1;
		p_Object[i].MaterialColor[2] = 1;
		p_Object[i].MaterialColor[3] = 1;

		p_Object[i].Position.x = 0;
		p_Object[i].Position.y = 0;
		p_Object[i].Position.z = 0;

		p_Object[i].RotAngle = 0;
		p_Object[i].RotX = 0;
		p_Object[i].RotY = 0;
		p_Object[i].RotZ = 0;

		p_Object[i].Scale.x = 1;
		p_Object[i].Scale.y = 1;
		p_Object[i].Scale.z = 1;
	}
}

void QuadCreator()
{
	for(int i = 0; i < SpheresCount; i++)
	{
		q_Object[i].isActive = true;
		q_Object[i].isColorBlended = true;
		q_Object[i].MaterialColor[0] = 1;
		q_Object[i].MaterialColor[1] = 1;
		q_Object[i].MaterialColor[2] = 1;
		q_Object[i].MaterialColor[3] = 1;

		q_Object[i].Position.x = 0;
		q_Object[i].Position.y = 0;
		q_Object[i].Position.z = 0;

		q_Object[i].RotAngle = 0;
		q_Object[i].RotX = 0;
		q_Object[i].RotY = 0;
		q_Object[i].RotZ = 0;

		q_Object[i].Scale.x = 1;
		q_Object[i].Scale.y = 1;
		q_Object[i].Scale.z = 1;
	}
}

void ModelCreator()
{
	for(int i = 0; i < 1; i++)
	{
		m_Object[i].isActive = true;
		m_Object[i].isColorBlended = true;
		m_Object[i].MaterialColor[0] = 1;
		m_Object[i].MaterialColor[1] = 1;
		m_Object[i].MaterialColor[2] = 1;
		m_Object[i].MaterialColor[3] = 1;

		m_Object[i].Position.x = 0;
		m_Object[i].Position.y = 0;
		m_Object[i].Position.z = 0;

		m_Object[i].RotAngle = 0;
		m_Object[i].RotX = 0;
		m_Object[i].RotY = 0;
		m_Object[i].RotZ = 0;

		m_Object[i].Scale.x = 1;
		m_Object[i].Scale.y = 1;
		m_Object[i].Scale.z = 1;
	}
}

void PointLightCreator(int Count, PointLight Object[Limit])
{
	for(int i = 0; i < Count; i++)
	{
	    Object[i].isActive = true;

		Object[i].PointLightColor[0] = 0;
		Object[i].PointLightColor[1] = 0;
		Object[i].PointLightColor[2] = 0;

		Object[i].PointLightRadius = 10;

		Object[i].Position.x = 0;
		Object[i].Position.y = 0;
		Object[i].Position.z = 0;
	}
}

void SpotLightCreator(int Count, SpotLight Object[Limit])
{
	for(int i = 0; i < Count; i++)
	{
	    Object[i].isActive = true;

		Object[i].SpotLightColor[0] = 0;
		Object[i].SpotLightColor[1] = 0;
		Object[i].SpotLightColor[2] = 0;

		Object[i].SpotDirection[0] = 1;
		Object[i].SpotDirection[1] = 1;
		Object[i].SpotDirection[2] = 1;

		Object[i].Position.x = 0;
		Object[i].Position.y = 0;
		Object[i].Position.z = 0;
	}
}

void DirectionalLightCreator(int Count, DirectionalLight Object[Limit])
{
	for(int i = 0; i < Count; i++)
	{
	    Object[i].isActive = true;

		Object[i].DirectionalLightColor[0] = 0;
		Object[i].DirectionalLightColor[1] = 0;
		Object[i].DirectionalLightColor[2] = 0;

		Object[i].LightDirection[0] = 1;
		Object[i].LightDirection[1] = 1;
		Object[i].LightDirection[2] = 1;
	}
}

void IstantiateCubes(int Count)
{
	for(int i = 0; i < Count; i++)
	{
		if(c_Object[i].isActive)
		{
			glPushMatrix();
			
			if(c_Object[i].isColorBlended)
			{
				glEnable(GL_BLEND);
		        glBlendFunc(GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA);
		        glColor4f(c_Object[i].MaterialColor[0], c_Object[i].MaterialColor[1], c_Object[i].MaterialColor[2], c_Object[i].MaterialColor[3]);
			}
			else if (!c_Object[i].isColorBlended)
			{
				glDisable(GL_BLEND);
				Mat.SetMaterial(c_Object[i].MaterialColor);
			}

			glTranslated(c_Object[i].Position.x, c_Object[i].Position.y, c_Object[i].Position.z);
			glRotated(c_Object[i].RotAngle, c_Object[i].RotX, c_Object[i].RotY, c_Object[i].RotZ);
	        glScaled(c_Object[i].Scale.x, c_Object[i].Scale.y, c_Object[i].Scale.z);
			glutSolidCube(1);
	        glPopMatrix();
		}
	}
}

void IstantiateSpheres(int Count)
{
	for(int i = 0; i < Count; i++)
	{
		if(s_Object[i].isActive)
		{
			glPushMatrix();
			
			if(s_Object[i].isColorBlended)
			{
				glEnable(GL_BLEND);
		        glBlendFunc(GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA);
		        glColor4f(s_Object[i].MaterialColor[0], s_Object[i].MaterialColor[1], s_Object[i].MaterialColor[2], s_Object[i].MaterialColor[3]);
			}
			else if (!s_Object[i].isColorBlended)
			{
				glDisable(GL_BLEND);
				Mat.SetMaterial(s_Object[i].MaterialColor);
			}

			glTranslated(s_Object[i].Position.x, s_Object[i].Position.y, s_Object[i].Position.z);
	        glRotated(s_Object[i].RotAngle, s_Object[i].RotX, s_Object[i].RotY, s_Object[i].RotZ);
	        glScaled(s_Object[i].Scale.x, s_Object[i].Scale.y, s_Object[i].Scale.z);
			glutSolidSphere(1, 256, 256);
	        glPopMatrix();
		}
	}
}

void IstantiatePlanes(int Count)
{
	for(int i = 0; i < Count; i++)
	{
		if(p_Object[i].isActive)
		{
			glPushMatrix();
			
			if(p_Object[i].isColorBlended)
			{
				glEnable(GL_BLEND);
		        glBlendFunc(GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA);
		        glColor4f(p_Object[i].MaterialColor[0], p_Object[i].MaterialColor[1], p_Object[i].MaterialColor[2], p_Object[i].MaterialColor[3]);
			}
			else if(!p_Object[i].isColorBlended)
			{
				glDisable(GL_BLEND);
				Mat.SetMaterial(p_Object[i].MaterialColor);
			}

			glTranslated(p_Object[i].Position.x, p_Object[i].Position.y, p_Object[i].Position.z);
			glRotated(p_Object[i].RotAngle, p_Object[i].RotX, p_Object[i].RotY, p_Object[i].RotZ);
	        glScaled(p_Object[i].Scale.x, p_Object[i].Scale.y, p_Object[i].Scale.z);
			glBegin(GL_QUADS);
            glVertex3f(-1, 0, -1); 
            glVertex3f( 1, 0, -1); 
            glVertex3f( 1, 0,  1); 
            glVertex3f(-1, 0,  1);
            glEnd();
	        glPopMatrix();
		}
	}
}

void IstantiateQuads(int Count)
{
	for(int i = 0; i < Count; i++)
	{
		if(q_Object[i].isActive)
		{
			glPushMatrix();
			
			if(q_Object[i].isColorBlended)
			{
				glEnable(GL_BLEND);
		        glBlendFunc(GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA);
				glColor4f(q_Object[i].MaterialColor[0], q_Object[i].MaterialColor[1], q_Object[i].MaterialColor[2], q_Object[i].MaterialColor[3]);
			}
			else if(!q_Object[i].isColorBlended)
			{
				glDisable(GL_BLEND);
				Mat.SetMaterial(q_Object[i].MaterialColor);
			}

			glTranslated(q_Object[i].Position.x, q_Object[i].Position.y, q_Object[i].Position.z);
	        glRotated(q_Object[i].RotAngle, q_Object[i].RotX, q_Object[i].RotY, q_Object[i].RotZ);
	        glScaled(q_Object[i].Scale.x, q_Object[i].Scale.y, q_Object[i].Scale.z);
		    glBegin(GL_QUADS);
            glVertex3f(-1, -1,  0); 
            glVertex3f( 1, -1,  0); 
            glVertex3f( 1,  1,  0); 
            glVertex3f(-1,  1,  0);
            glEnd();
	        glPopMatrix();
		}
	}
}

void IstantiateModels(int Count)
{
	for(int i = 0; i < Count; i++)
	{
		if(m_Object[i].isActive)
		{
			glPushMatrix();
			
			if(m_Object[i].isColorBlended)
			{
				glEnable(GL_BLEND);
		        glBlendFunc(GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA);
		        glColor4f(m_Object[i].MaterialColor[0], m_Object[i].MaterialColor[1], m_Object[i].MaterialColor[2], m_Object[i].MaterialColor[3]);
			}
			else if (!m_Object[i].isColorBlended)
			{
				glDisable(GL_BLEND);
				Mat.SetMaterial(m_Object[i].MaterialColor);
			}

			glTranslated(m_Object[i].Position.x, m_Object[i].Position.y, m_Object[i].Position.z);
			glRotated(m_Object[i].RotAngle, m_Object[i].RotX, m_Object[i].RotY, m_Object[i].RotZ);
	        glScaled(m_Object[i].Scale.x, m_Object[i].Scale.y, m_Object[i].Scale.z);	
		    mModel[i].mIstantiate();
	        glPopMatrix();
		}
	}
}

void IstantiatePointLights(int Count)
{
	for(int i = 0; i < Count; i++)
	{
		if(p_Light[i].isActive)
		{
			glPushMatrix();

			LightableObjects[i].PointLight(GL_LIGHT5 + i,
				p_Light[i].isActive,
				Gizmos,
				p_Light[i].Position,
				p_Light[i].PointLightColor,
				p_Light[i].PointLightRadius);

	        glPopMatrix();
		}
		else
			glDisable(GL_LIGHT5 + i);
	}
}

void IstantiateSpotLight(int Count)
{
	float v[4];
	for(int i = 0; i < Count; i++)
	{
		if(s_Light[i].isActive)
		{
			glPushMatrix();
			v[0] = -s_Light[i].SpotDirection[0]; v[1] = -s_Light[i].SpotDirection[1]; v[2] = -s_Light[i].SpotDirection[2]; v[3] = 0.0f;
			LightableObjects[i].SpotLight(GL_LIGHT3 + i, 
				s_Light[i].isActive, 
				Gizmos,
				s_Light[i].Position,
				v,
				s_Light[i].SpotLightColor);

	        glPopMatrix();
		}
		else
			glDisable(GL_LIGHT3 + i);
	}
}

void IstantiateDirectionalLight(int Count)
{
	float v[4];
	for(int i = 0; i < Count; i++)
	{
		if(d_Light[i].isActive)
		{
			glPushMatrix();
			v[0] = -d_Light[i].LightDirection[0]; v[1] = -d_Light[i].LightDirection[1]; v[2] = -d_Light[i].LightDirection[2]; v[3] = 0.0f;
			LightableObjects[i].DirectionalLight(GL_LIGHT1 + i, 
				d_Light[i].isActive, 
				v,
				d_Light[i].DirectionalLightColor);
			glPopMatrix();
		}
		else
			glDisable(GL_LIGHT1 + i);
	}
}

void IstantiateAudiosSource(int Count)
{
	for(int i = 0; i < Count; i++)
	{
		aAudio[i].Istantiate(true, 
			                 Gizmos);
	}
}

void Ortho2D(int W, int H)
{
	glMatrixMode(GL_PROJECTION);
	glPushMatrix();
	glLoadIdentity();
	gluOrtho2D(0, W, H, 0);
	glMatrixMode(GL_MODELVIEW);
}

void InitStates()
{
	P_Mode.FramePerSecond();
	P_Mode.GetMode();
}

void DrawStates()
{
	InitStates();
	Ortho2D(Width, Height);
	glPushMatrix();
	glLoadIdentity();
	P_Mode.RenderStates();
	glPopMatrix();
	View(Width, Height);
}

void IstantiateGameObjects()
{
	gfx.RenderScene(Gizmos, bLighting, 
		AmbientCOLOR,
		BackgroundColor1,
		BackgroundColor2,
		bBackground, bSkybox,
		TextureTGA,
		cam, 
		Width, Height, 
		View);
		

	IstantiateCubes            (CubesCount);
	IstantiateSpheres          (SpheresCount);
	IstantiatePlanes           (PlanesCount);
	IstantiateQuads            (QuadsCount);
	IstantiateModels           (1);
	IstantiatePointLights      (PointLightCount);
	IstantiateSpotLight        (SpotLightCount);
	IstantiateDirectionalLight (DirectionalLightCount);

	if(AudioAdded)
	   IstantiateAudiosSource     (1);
}

GLfloat StereoOffset = 0.1f;
GLboolean ActivateStereo = GL_FALSE;

void DisplayScene(void)
{
	cam[CurCamera].Update();
    cam[CurCamera].Apply();

	glClear(GL_COLOR_BUFFER_BIT);

	glColor4f(1, 0, 0, 1);

	if(MSAA)
		glEnable(GL_MULTISAMPLE_ARB);
	else if (!MSAA)
		glDisable(GL_MULTISAMPLE_ARB);

	if(FILLMODE)
		glPolygonMode(GL_FRONT_AND_BACK, GL_FILL);
	else if (LINEMODE)
		glPolygonMode(GL_FRONT_AND_BACK, GL_LINE);
	else if (POINTMODE)
		glPolygonMode(GL_FRONT_AND_BACK, GL_POINT);

	fFog.FogInit(efFog, fogColor, 5, 100);

	if(!ActivateStereo)
		IstantiateGameObjects();
	else if (ActivateStereo)
	Stereo.InitStereoscopic(IstantiateGameObjects, StereoOffset);

	if(P_Mode.isPlayMode == GL_FALSE)
	   TwDraw();

	if(P_Mode.isPlayMode == GL_TRUE)
	   DrawStates();

	glutSwapBuffers();
}

void TW_CALL AddGameObjects(void *clientData)
{
	ObjectsHierarchy();
	CubeCreator();
	SphereCreator();
	PlaneCreator();
	QuadCreator();
	PointLightCreator         (PointLightCount, p_Light);
	SpotLightCreator          (SpotLightCount,  s_Light);
	DirectionalLightCreator   (DirectionalLightCount, d_Light);
	Log("SCENE-OBJECTS->" ,"SOME OBJECTS WAS ADDED TO SCENE", 1);
	TwDefine(" Hierarchy/AddGameObjects readonly ");
}

void TW_CALL ImportModel(void *clientData)
{
	ModelHierarchy();
	ModelCreator();
	Log("SCENE-OBJECTS->" ,"MODEL WAS IMPORTED TO SCENE", 1);
	TwDefine(" Hierarchy/ImportModel readonly ");
}

void TW_CALL AddAudioSource(void *clientData)
{
	AudioAdded = true;
	Log("SCENE-OBJECTS->" ,"AUDIO SOURCE WAS ADDED TO SCENE", 1);
	TwDefine(" Hierarchy/AddAudioSource readonly ");
}

void KeyboardFunc (unsigned char key, int x, int y)
{
	if(key == 27) // Escape
	{
		exit(0);
	}
	if(P_Mode.isPlayMode == GL_FALSE)
	{
	 if(key == 82 || key == 114 || key == -86 || key == -118) //R
	 {
		cam[CurCamera].Reset();
	 }
	}

	if (TwEventKeyboardGLUT(key, x, y))
        glutPostRedisplay(); 
}

void BarsCreator()
{
	//*****************************
	//AntTweakBar: Scene Hierarchy//
	//*****************************

	int MinObjects = 0;
	int MaxObjects = 500;
	int MaxLights = 2;

	UI = TwNewBar("Scene");
	TwDefine(" GLOBAL fontsize=3 help='Effect Editor, This Tool a Part of Fariduns Game Engine (FGE)' ");
	TwDefine(" Scene label='Scene Settings' size='300 300' position='10 15' color='0 0 0' alpha=180 help='By Panel \"Scene Settings\" You can Set Up Your Scene' ");

	TwAddVarRW(UI, "Gizmos", TW_TYPE_BOOLCPP, &Gizmos, " group='Scene' ");
	TwAddVarRW(UI, "Draw Background", TW_TYPE_BOOLCPP, &bBackground, " group='Scene' ");
	TwAddVarRW(UI, "Skybox", TW_TYPE_BOOLCPP, &bSkybox, " group='Scene' ");

	TwAddVarRW(UI, "Up Color", TW_TYPE_COLOR3F, &BackgroundColor1, " group='Scene' ");
	TwAddVarRW(UI, "Down Color", TW_TYPE_COLOR3F, &BackgroundColor2, " group='Scene' ");

	TwAddVarRW(UI, "Lighting", TW_TYPE_BOOLCPP, &bLighting, "group='Light' ");
	TwAddVarRW(UI, "Ambient Color", TW_TYPE_COLOR3F, &AmbientCOLOR, "group='Light' ");

	TwAddVarRW(UI, "MSAA", TW_TYPE_BOOLCPP, &MSAA, "group='Quality'");

	//*****************************
	//AntTweakBar: Objects Hierarchy//
	//*****************************

	Hierarchy = TwNewBar("Hierarchy");
	TwDefine("Hierarchy label='Objects Hierarchy' size='300 300' position='870 15' color='0 0 0' alpha=180");

	TwAddVarRW(Hierarchy, "CubesCount", TW_TYPE_INT32, &CubesCount, "label='Cubes Count' group='Objects Creator'");

	TwSetParam(Hierarchy, "CubesCount", "min", TW_PARAM_INT32, 1, &MinObjects);
	TwSetParam(Hierarchy, "CubesCount", "max", TW_PARAM_INT32, 1, &MaxObjects);

	TwAddVarRW(Hierarchy, "SpheresCount", TW_TYPE_INT32, &SpheresCount, "label='Spheres Count' group='Objects Creator'");

	TwSetParam(Hierarchy, "SpheresCount", "min", TW_PARAM_INT32, 1, &MinObjects);
	TwSetParam(Hierarchy, "SpheresCount", "max", TW_PARAM_INT32, 1, &MaxObjects);

	TwAddVarRW(Hierarchy, "PlanesCount", TW_TYPE_INT32, &PlanesCount, "label='Planes Count' group='Objects Creator'");

	TwSetParam(Hierarchy, "PlanesCount", "min", TW_PARAM_INT32, 1, &MinObjects);
	TwSetParam(Hierarchy, "PlanesCount", "max", TW_PARAM_INT32, 1, &MaxObjects);

	TwAddVarRW(Hierarchy, "QuadsCount", TW_TYPE_INT32, &QuadsCount, "label='Quads Count' group='Objects Creator'");

	TwSetParam(Hierarchy, "QuadsCount", "min", TW_PARAM_INT32, 1, &MinObjects);
	TwSetParam(Hierarchy, "QuadsCount", "max", TW_PARAM_INT32, 1, &MaxObjects);

	TwAddSeparator(Hierarchy, "Separator1", "group='Objects Creator'");

	TwAddVarRW(Hierarchy, "PointLightCount", TW_TYPE_INT32, &PointLightCount, "label='Point Lights Count' group='Objects Creator'");

	TwSetParam(Hierarchy, "PointLightCount", "min", TW_PARAM_INT32, 1, &MinObjects);
	TwSetParam(Hierarchy, "PointLightCount", "max", TW_PARAM_INT32, 1, &MaxLights);

	TwAddVarRW(Hierarchy, "SpotLightCount", TW_TYPE_INT32, &SpotLightCount, "label='Spot Lights Count' group='Objects Creator'");

	TwSetParam(Hierarchy, "SpotLightCount", "min", TW_PARAM_INT32, 1, &MinObjects);
	TwSetParam(Hierarchy, "SpotLightCount", "max", TW_PARAM_INT32, 1, &MaxLights);

	TwAddVarRW(Hierarchy, "DirectionalLightCount", TW_TYPE_INT32, &DirectionalLightCount, "label='Directional Light Count' group='Objects Creator'");

	TwSetParam(Hierarchy, "DirectionalLightCount", "min", TW_PARAM_INT32, 1, &MinObjects);
	TwSetParam(Hierarchy, "DirectionalLightCount", "max", TW_PARAM_INT32, 1, &MaxLights);

	TwAddButton(Hierarchy, "AddGameObjects", AddGameObjects, NULL, "label='Add Game Objects' group='Objects Creator'");
	TwAddButton(Hierarchy, "ImportModel", ImportModel, NULL, "label='Import Model' group='Objects Creator'");
	TwAddButton(Hierarchy, "AddAudioSource", AddAudioSource, NULL, "label='Add Audio Source' group='Objects Creator'");

}

void SpecialFunc(int key, int x, int y)
{
	switch (key)
	{
	case GLUT_KEY_PAGE_UP:
		if(P_Mode.isPlayMode == GL_FALSE)
		cam[CurCamera].Movement_y += Speed;
		break;
	case GLUT_KEY_PAGE_DOWN:
		if(P_Mode.isPlayMode == GL_FALSE)
		cam[CurCamera].Movement_y -= Speed;
		break;
	case GLUT_KEY_RIGHT:
		if(P_Mode.isPlayMode == GL_FALSE)
		cam[CurCamera].Movement_x += Speed;
		break;
	case GLUT_KEY_LEFT:
		if(P_Mode.isPlayMode == GL_FALSE)
	 	cam[CurCamera].Movement_x -= Speed;
		break;
	case GLUT_KEY_UP:
		if(P_Mode.isPlayMode == GL_FALSE)
		cam[CurCamera].Movement_z -= Speed;
		break;
	case GLUT_KEY_DOWN:
		if(P_Mode.isPlayMode == GL_FALSE)
		cam[CurCamera].Movement_z += Speed;
		break;
	case GLUT_KEY_F12:
		 P_Mode.EnterFullScreen();
		 break;
	case GLUT_KEY_F11:
		 P_Mode.LeaveFullScreen();
		 break;
	case GLUT_KEY_F1:
		if(P_Mode.isPlayMode == GL_TRUE)
		    ActivateStereo = !ActivateStereo;
		break;
	case GLUT_KEY_F2:
		if(P_Mode.isPlayMode == GL_TRUE)
		{
		   StereoOffset += 0.1f;
		   if(StereoOffset > 1)
			  StereoOffset = 1;
		}
		break;
	case GLUT_KEY_F3:
		if(P_Mode.isPlayMode == GL_TRUE)
		{
		   StereoOffset -= 0.1f;
		   if(StereoOffset < 0.1f)
			  StereoOffset = 0.1f;
		}
		break;
	case GLUT_KEY_F6:
		P_Mode.Play(&Gizmos);
		if(AudioAdded)
			LoadAudio();
		break;
	case GLUT_KEY_F5:
		P_Mode.Exit(&Gizmos);
		for(int i = 0; i < 1; i++)
			if(AudioAdded)
			   aAudio[i].Clear();
		ActivateStereo = GL_FALSE;
		break;
	default:
		Log("KEYBOARD->KEY->PRESSED->", "UNKNOW", 1);
		break;
	}

	 if (TwEventSpecialGLUT(key, x, y))
        glutPostRedisplay();

}

void MouseFunc(int button, int state, int x, int y)
{
	if(P_Mode.isPlayMode == GL_FALSE)
	{
	  if(button == GLUT_RIGHT_BUTTON)
	  {
		if(state == GLUT_DOWN)
		{
			FreeCamera = true;
		}
		if(state == GLUT_UP)
		{
			FreeCamera = false;
		}
      }
	}

	if (TwEventMouseButtonGLUT(button, state, x, y))
        glutPostRedisplay();
}

void Motion(int x, int y)
{
	if(P_Mode.isPlayMode == GL_FALSE)
	{
	 if(FreeCamera)
	 {
		 cam[CurCamera].Delta_x = float((y) - P_Mode.SCREEN_HEIGHT() * 2)/0.2;
	     cam[CurCamera].Delta_y = float((x) - P_Mode.SCREEN_WIDTH() * 2)/0.2;
	 }
	}

	 if (TwEventMouseMotionGLUT(x, y))
        glutPostRedisplay(); 
}


void MouseWheel(int wheel, int direction, int x, int y)
{
	if(P_Mode.isPlayMode == GL_FALSE)
	   cam[CurCamera].Movement_z -= direction;
}

void ReshapeFunc(int W, int H)
{
	Width = W;
	Height = H;
	View(W, H);
	TwWindowSize(W, H);
}

void Idle()
{
	glutPostRedisplay();
}

void InitTextures(Texture *tTexture)
{
	GLfloat TextureParams = GL_LINEAR; // GL_LINEAR, GL_NEAREST

	tTexture[2].LoadTGA(TextureParams, "Default Scene/Skybox/Top.tga");
	tTexture[3].LoadTGA(TextureParams, "Default Scene/Skybox/Bottom.tga");
	tTexture[4].LoadTGA(TextureParams, "Default Scene/Skybox/Left.tga");
	tTexture[5].LoadTGA(TextureParams, "Default Scene/Skybox/Right.tga");
	tTexture[6].LoadTGA(TextureParams, "Default Scene/Skybox/Front.tga");
	tTexture[7].LoadTGA(TextureParams, "Default Scene/Skybox/Back.tga");
}


void LoadModel()
{
	for(int i = 0; i < 1; i++)
		mModel[i].LoadModel("Default Scene/Models/mModel.fbx");
}

void LoadAudio()
{
	for(int i = 0; i < 1; i++)
	{
		aAudio[i].LoadAudio("Default Scene/Audio/audio.mp3");
		aAudio[i].Play2D(true, false, 1);
	}
}

void LogGLContext()
{
	cout << "Vendor Type: " << glGetString(GL_VENDOR) << endl;
	cout << "Renderer: " << glGetString(GL_RENDERER) << "\n" << endl;

	cout << "OpenGL Version: " << glGetString(GL_VERSION) << endl;
	cout << "OpenGL Shading Language Version: " << glGetString(GL_SHADING_LANGUAGE_VERSION) << endl;

	int GLMaxLights = 0, GLMaxTexture = 0, GLMaxTextureUnitsARB = 0, GLMax3DTexture = 0;

	glGetIntegerv(GL_MAX_LIGHTS, &GLMaxLights);
	glGetIntegerv(GL_MAX_TEXTURE_SIZE, &GLMaxTexture);
	glGetIntegerv(GL_MAX_TEXTURE_UNITS_ARB, &GLMaxTextureUnitsARB);
	glGetIntegerv(GL_MAX_3D_TEXTURE_SIZE, &GLMax3DTexture);

	cout << "OpenGL Max Lights: " << GLMaxLights << endl;
	cout << "OpenGL Max Textures: " << GLMaxTexture << endl;
	cout << "OpenGL Max Texture Units ARB: " << GLMaxTextureUnitsARB << endl;
	cout << "OpenGL Max 3D Textures: " << GLMax3DTexture << "\n" << endl;

	if(!GLEW_ARB_shading_language_100)
	{
		Log("FGE->SUPPORT->GLEW_ARB_shading_language->", "FALSE" , 1);
	}
	else if(GLEW_ARB_shading_language_100)
	{
		Log("FGE->SUPPORT->GLEW_ARB_shading_language->", "TRUE" , 1);
	}

	if(!GLEW_ARB_shader_objects)
	{
		Log("FGE->SUPPORT->GLEW_ARB_shader_objects->", "FALSE" , 1);
	}
	else if(GLEW_ARB_shader_objects)
	{
		Log("FGE->SUPPORT->GLEW_ARB_shader_objects->", "TRUE" , 1);
	}

	if(!GLEW_ARB_vertex_shader)
	{
		Log("FGE->SUPPORT->GLEW_ARB_vertex_shader->", "FALSE" , 1);
	}
	else if(GLEW_ARB_vertex_shader)
	{
		Log("FGE->SUPPORT->GLEW_ARB_vertex_shader->", "TRUE" , 1);
	}

	if(!GLEW_ARB_fragment_shader)
	{
		Log("FGE->SUPPORT->GLEW_ARB_fragment_shader->", "FALSE" , 1);
	}
	else if(GLEW_ARB_fragment_shader)
	{
		Log("FGE->SUPPORT->GLEW_ARB_fragment_shader->", "TRUE" , 1);
	}

	if(!GLEW_ARB_multitexture)
	{
		Log("FGE->SUPPORT->GLEW_ARB_multitexture->", "FALSE" , 1);
	}
	else if(GLEW_ARB_multitexture)
	{
		Log("FGE->SUPPORT->GLEW_ARB_multitexture->", "TRUE" , 1);
	}

	if(!GLEW_ARB_texture_compression)
	{
		Log("FGE->SUPPORT->GLEW_ARB_texture_compression->", "FALSE" , 1);
	}
	else if(GLEW_ARB_texture_compression)
	{
		Log("FGE->SUPPORT->GLEW_ARB_texture_compression->", "TRUE" , 1);
	}

	if(!GLEW_EXT_texture_compression_s3tc)
	{
		Log("FGE->SUPPORT->GLEW_EXT_texture_compression_s3tc->", "FALSE" , 1);
	}
	else if(GLEW_EXT_texture_compression_s3tc)
	{
		Log("FGE->SUPPORT->GLEW_EXT_texture_compression_s3tc->", "TRUE" , 1);
	}

	if(!GLEW_EXT_texture_compression_rgtc)
	{
		Log("FGE->SUPPORT->GLEW_EXT_texture_compression_rgtc->", "FALSE" , 1);
	}
	else if(GLEW_EXT_texture_compression_rgtc)
	{
		Log("FGE->SUPPORT->GLEW_EXT_texture_compression_rgtc->", "TRUE" , 1);
	}

	if(!GLEW_EXT_texture_compression_latc)
	{
		Log("FGE->SUPPORT->GLEW_EXT_texture_compression_latc->", "FALSE" , 1);
	}
	else if(GLEW_EXT_texture_compression_latc)
	{
		Log("FGE->SUPPORT->GLEW_EXT_texture_compression_latc->", "TRUE" , 1);
	}

	if(!GLEW_EXT_texture_compression_dxt1)
	{
		Log("FGE->SUPPORT->GLEW_EXT_texture_compression_dxt1->", "FALSE" , 1);
	}
	else if(GLEW_EXT_texture_compression_dxt1)
	{
		Log("FGE->SUPPORT->GLEW_EXT_texture_compression_dxt1->", "TRUE" , 1);
	}
}

void InitFunctions(bool InitTW, bool mLoadModel, bool ResetCam)
{
	glewExperimental = GL_TRUE;

	if(glewInit() != GLEW_OK)
	{
		Log("GLEW-INIT->", "ERROR->CAN'T INIT GLEW", 1);
		MessageDialogDefault("Fatal Error!!!", "Can't Init GLEW", MB_ICONERROR | MB_OK, 1);
		return;
	}

	LogGLContext();

	/*InitTextures(TextureTGA);*/
	Init(ResetCam);

	//if(mLoadModel)
	//   LoadModel();

	//LoadSTSFile("STSFILES/Scene.sts", MODEL, mModel, aAudio, TextureTGA);


	glutDisplayFunc(DisplayScene);
	glutReshapeFunc(ReshapeFunc);


	if(InitTW)
	    TwInit(TW_OPENGL, NULL);

	glutMouseFunc(MouseFunc);
    glutMotionFunc(Motion);
	glutMouseWheelFunc(MouseWheel);
	glutPassiveMotionFunc(Motion);
    glutKeyboardFunc(KeyboardFunc);
	glutSpecialFunc(SpecialFunc);

	if(InitTW)
	   TwGLUTModifiersFunc(glutGetModifiers);

	glutIdleFunc(Idle);
}

void ContextMenu(int M)
{
	switch(M)
	{
	case 1:
		exit(0);
	break;
	case 2:
		efFog = true;
		Log("FOG-STATUS->", "TRUE", 1);
	break;
	case 3:
		efFog = false;
		Log("FOG-STATUS->", "FALSE", 1);
	break;
	}
}

void ContextMenuRenderMode(int M)
{
	switch(M)
	{
	case 1:
		FILLMODE = GL_TRUE;
		LINEMODE = GL_FALSE;
		POINTMODE = GL_FALSE;
		Log("RENDER-MODE-STATUS->" ,"GL_FILL", 1);
	break;
	case 2:
		FILLMODE = GL_FALSE;
		LINEMODE = GL_TRUE;
		POINTMODE = GL_FALSE;
		Log("RENDER-MODE-STATUS->" ,"GL_LINE", 1);
	break;
	case 3:
	    FILLMODE = GL_FALSE;
		LINEMODE = GL_FALSE;
		POINTMODE = GL_TRUE;
		Log("RENDER-MODE-STATUS->" ,"GL_POINT", 1);
	break;
	}
}

void ContextMenuScene(int M)
{
	switch(M)
	{
	case 1:
		STARTUPINFO SI;
		PROCESS_INFORMATION PINF;

		ZeroMemory(&SI, sizeof(SI));
		SI.cb = sizeof(SI);
		ZeroMemory(&PINF, sizeof(PINF));

		if(!CreateProcess((LPCSTR)"Effect Editor.exe", NULL, NULL, NULL, NULL, NULL, NULL, NULL, &SI, &PINF))
		{
			MessageDialogDefault("Fatal Error!!!", "Can't Restart The Scene!!!", MB_ICONERROR | MB_OK, 1);
			return;
		}

		WaitForSingleObject(PINF.hProcess, INFINITE);

		CloseHandle(PINF.hProcess);
		CloseHandle(PINF.hThread);
		break;
	}
}

void ContextMenuGameModeEntry(int M)
{
	switch (M)
	{
	case 1:
		P_Mode.Play(&Gizmos);
		if(AudioAdded)
			LoadAudio();
		break;
	case 2:
		P_Mode.Exit(&Gizmos);
		for(int i = 0; i < 1; i++)
			if(AudioAdded)
			   aAudio[i].Clear();
		ActivateStereo = GL_FALSE;
		break;
	}
}

void Terminate()
{
	for(int i = 0; i < 1; i++)
	{
    	mModel[i].Clear();
		aAudio[i].Clear();
	}
	//delete[] mModel;
	delete[] c_Object;
	delete[] p_Object;
	delete[] q_Object;
	delete[] s_Object;
	delete[] p_Light;
	delete[] s_Light;
	delete[] d_Light;
	delete[] LightableObjects;
	delete[] cam;
	//delete[] TextureTGA;
	//delete[] aAudio;
	delete[] a_Source;
	glDisableClientState(GL_VERTEX_ARRAY);
	glDisable(GL_SCISSOR_TEST);
	glDisable(GL_LIGHTING);
	glDisable(GL_BLEND);
	TwTerminate();
}

int main(int argc, char** argv)
{
	int _ContextMenuRenderMode;
	int _ContextMenuScene;
	int _ContextMenuGameModeEntry;

	SetConsoleTitle (TEXT("Faridun's Game Engine: Effect Editor"));
	Log("FARIDUN'S GAME ENGINE : ", "Effect Editor\n", 1);
    Log("GRAPHICS BY ", "OPENGL(OPEN GRAPHICS LIBRARY)", 1);
	Log("AUDIO BY ", "irrKlang", 1);
	Log("DEVELOPED BY ", "FARIDUN BERDIEV\n", 1);
	glutInit(&argc, argv);

	//*****************************
	//Editor Window//
	//*****************************

	glutInitDisplayMode(GLUT_DEPTH | GLUT_SINGLE | GLUT_RGBA | GLUT_MULTISAMPLE);
	glutInitWindowSize(Width, Height);
	glutInitWindowPosition(40, 40);
	glutCreateWindow(WindowTitle.c_str());

	InitFunctions(true, true, true);

	_ContextMenuRenderMode = glutCreateMenu(ContextMenuRenderMode);
	glutAddMenuEntry("FILL", 1);
	glutAddMenuEntry("LINE", 2);
	glutAddMenuEntry("POINT", 3);

	_ContextMenuGameModeEntry = glutCreateMenu(ContextMenuGameModeEntry);
	glutAddMenuEntry("Run   (F6)", 1);
	glutAddMenuEntry("Exit  (F5)", 2);

	_ContextMenuScene = glutCreateMenu(ContextMenuScene);
	glutAddSubMenu("Game Mode", _ContextMenuGameModeEntry);
	glutAddMenuEntry("Reset Scene(New Scene)", 1);

	glutCreateMenu(ContextMenu);
	glutAddSubMenu("Scene", _ContextMenuScene);
	glutAddSubMenu("Render Mode", _ContextMenuRenderMode);
	glutAddMenuEntry("Enable Fog Effect", 2);
	glutAddMenuEntry("Disable Fog Effect", 3);
	glutAddMenuEntry("Quit", 1);
	glutAttachMenu(GLUT_MIDDLE_BUTTON);

	BarsCreator();
	
	atexit(Terminate);
	glutMainLoop();	
	return 1;
}