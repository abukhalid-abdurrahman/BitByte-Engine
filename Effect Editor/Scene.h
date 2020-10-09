#ifndef Scene_H
#define Scene_H

extern enum STS
{
	AUDIO = 0,
	MODEL = 1,
	TEXTURE = 2
};

void LoadSTSFile(string FileName, STS Type, vector<Model>MDL, vector<Audio>ADO, vector<Texture>TXR);

#endif

