#include "stdafx.h"
#include "Scene.h"

using namespace std;

void LoadSTSFile(string FileName, STS Type, vector<Model>MDL, vector<Audio>ADO, vector<Texture>TXR)
{
	int i = 0;

	string STSMODELPATH;
	string STSAUDIOPATH;
	string STSTEXTUREPATH;

	ifstream STSFile(FileName.c_str());

	STSFile >> STSMODELPATH;
	STSFile >> STSAUDIOPATH;
	STSFile >> STSTEXTUREPATH;

	ifstream STSModelFile(STSMODELPATH.c_str());
	ifstream STSAudioFile(STSAUDIOPATH.c_str());
	ifstream STSTextureFile(STSTEXTUREPATH.c_str());

	string MDLPathes[256];
	string ADOPathes[256];
	char TXRPathes[256];
	
	switch (Type)
	{
	case MODEL:
		i = 0;
		while(STSModelFile.eof())
		{
			MDL.resize(i);
			STSModelFile >> MDLPathes[i];
			MDL[i].LoadModel(MDLPathes[i]);
			i++;
		}
		break;
	case AUDIO:
		i = 0;
		while(STSAudioFile.eof())
		{
			ADO.resize(i);
			STSAudioFile >> ADOPathes[i];
			ADO[i].LoadAudio(ADOPathes[i].c_str());
			i++;
		}
		break;
	case TEXTURE:
		i = 0;
		while(STSTextureFile.eof())
		{
			TXR.resize(i);
			STSTextureFile >> TXRPathes[i];
			TXR[i].LoadTGA(GL_LINEAR, TXRPathes);
			i++;
		}
		break;
	}
	
}