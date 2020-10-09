#ifndef MODEL_H
#define MODEL_H

#include <assimp/cimport.h>
#include <assimp/scene.h>
#include <assimp/postprocess.h>
#include <assimp/Importer.hpp>

#include <vector>

class Model
{
public:
    struct ModelEntry 
	{
		static enum BUFFERS 
		{
			VERTEX_BUFFER, 
			TEXCOORD_BUFFER, 
			NORMAL_BUFFER, 
			INDEX_BUFFER
		};

		GLuint VAO;
		GLuint VBO[4];

		unsigned int ElementCount;

		ModelEntry(aiMesh *mMesh);
		~ModelEntry();

		void Load(aiMesh *mesh);
		void mIstantiate();
	};

	vector<ModelEntry*> modelEntries;
public:
	Model(void);
	~Model(void);


	void LoadModel(const string& mFileName);
	void Clear();
	void mIstantiate();
};
#endif

