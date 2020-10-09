//////////////////////////////////
//Разработчик: Faridun Berdiev
//****************************
//Имя Файл: Model.cpp
//******************
//Версия: v0.1.8
//************
//Импорт Моделей через Assimp(Open Assets Importer)
//*****************************************
//////////////////////////////////

#include "stdafx.h"
#include "Model.h"

#include <assimp/cimport.h>
#include <assimp/scene.h>
#include <assimp/postprocess.h>
#include <assimp/Importer.hpp>

Model::Model(void)
{
	//Nothing to do...
}

Model::~Model(void)
{
	//Nothing to do...
}

Model::ModelEntry::ModelEntry(aiMesh *mMesh)
{
	VBO[VERTEX_BUFFER] = NULL;
	VBO[TEXCOORD_BUFFER] = NULL;
	VBO[NORMAL_BUFFER] = NULL;
	VBO[INDEX_BUFFER] = NULL;

	glGenVertexArrays(1, &VAO);
	glBindVertexArray(VAO);

	ElementCount = mMesh->mNumFaces * 3;

	if(mMesh->HasPositions()) {
		float *vertices = new float[mMesh->mNumVertices * 3];
		for(int i = 0; i < mMesh->mNumVertices; ++i) {
			vertices[i * 3] = mMesh->mVertices[i].x;
			vertices[i * 3 + 1] = mMesh->mVertices[i].y;
			vertices[i * 3 + 2] = mMesh->mVertices[i].z;
		}

		glGenBuffers(1, &VBO[VERTEX_BUFFER]);
		glBindBuffer(GL_ARRAY_BUFFER, VBO[VERTEX_BUFFER]);
		glBufferData(GL_ARRAY_BUFFER, 3 * mMesh->mNumVertices * sizeof(GLfloat), vertices, GL_STATIC_DRAW);

		glVertexAttribPointer(0, 3, GL_FLOAT, GL_FALSE, 0, NULL);
		glEnableVertexAttribArray (0);

		delete vertices;
	}

	if(mMesh->HasTextureCoords(0)) {
		float *texCoords = new float[mMesh->mNumVertices * 2];
		for(int i = 0; i < mMesh->mNumVertices; ++i) {
			texCoords[i * 2] = mMesh->mTextureCoords[0][i].x;
			texCoords[i * 2 + 1] = mMesh->mTextureCoords[0][i].y;
		}

		glGenBuffers(1, &VBO[TEXCOORD_BUFFER]);
		glBindBuffer(GL_ARRAY_BUFFER, VBO[TEXCOORD_BUFFER]);
		glBufferData(GL_ARRAY_BUFFER, 2 * mMesh->mNumVertices * sizeof(GLfloat), texCoords, GL_STATIC_DRAW);

		glVertexAttribPointer(1, 3, GL_FLOAT, GL_FALSE, 0, NULL);
		glEnableVertexAttribArray (1);

		delete texCoords;
	}


	if(mMesh->HasNormals()) {
		float *Normals = new float[mMesh->mNumVertices * 3];
		for(int i = 0; i < mMesh->mNumVertices; ++i) {
			Normals[i * 3] = mMesh->mNormals[i].x;
			Normals[i * 3 + 1] = mMesh->mNormals[i].y;
			Normals[i * 3 + 2] = mMesh->mNormals[i].z;
		}

		glGenBuffers(1, &VBO[NORMAL_BUFFER]);
		glBindBuffer(GL_ARRAY_BUFFER, VBO[NORMAL_BUFFER]);
		glBufferData(GL_ARRAY_BUFFER, 3 * mMesh->mNumVertices * sizeof(GLfloat), Normals, GL_STATIC_DRAW);

		glVertexAttribPointer(2, 3, GL_FLOAT, GL_FALSE, 0, NULL);
		glEnableVertexAttribArray (2);

		delete Normals;
	}
	

	if(mMesh->HasFaces()) {
		unsigned int *Indices = new unsigned int[mMesh->mNumFaces * 3];
		for(int i = 0; i < mMesh->mNumFaces; ++i) {
			Indices[i * 3] = mMesh->mFaces[i].mIndices[0];
			Indices[i * 3 + 1] = mMesh->mFaces[i].mIndices[1];
			Indices[i * 3 + 2] = mMesh->mFaces[i].mIndices[2];
		}

		glGenBuffers(1, &VBO[INDEX_BUFFER]);
		glBindBuffer(GL_ELEMENT_ARRAY_BUFFER, VBO[INDEX_BUFFER]);
		glBufferData(GL_ELEMENT_ARRAY_BUFFER, 3 * mMesh->mNumFaces * sizeof(GLuint), Indices, GL_STATIC_DRAW);

		glVertexAttribPointer(3, 3, GL_FLOAT, GL_FALSE, 0, NULL);
		glEnableVertexAttribArray (3);

		delete Indices;
	}
	

	glBindBuffer(GL_ARRAY_BUFFER, 0);
	glBindVertexArray(0);
}

Model::ModelEntry::~ModelEntry()
{
	if(VBO[VERTEX_BUFFER]) {
		glDeleteBuffers(1, &VBO[VERTEX_BUFFER]);
	}

	if(VBO[TEXCOORD_BUFFER]) {
		glDeleteBuffers(1, &VBO[TEXCOORD_BUFFER]);
	}

	if(VBO[NORMAL_BUFFER]) {
		glDeleteBuffers(1, &VBO[NORMAL_BUFFER]);
	}

	if(VBO[INDEX_BUFFER]) {
		glDeleteBuffers(1, &VBO[INDEX_BUFFER]);
	}

	glDeleteVertexArrays(1, &VAO);
}

void Model::ModelEntry::mIstantiate()
{
	glBindVertexArray(VAO);
	glDrawElements(GL_TRIANGLES, ElementCount, GL_UNSIGNED_INT, NULL);
	glBindVertexArray(0);
}

void Model::LoadModel(const string& mFileName)
{
	Assimp::Importer mImporter;
	const aiScene* mScene = mImporter.ReadFile(mFileName, 
		aiProcessPreset_TargetRealtime_Quality);
	if(!mScene)
	{
		Log("IMPORT-STATUS->", mImporter.GetErrorString(), 1);
		MessageDialogDefault("Fatal Error!!!", mImporter.GetErrorString(), MB_ICONERROR | MB_OK, 1);
	}

	for(int i = 0; i < mScene->mNumMeshes; i++)
		modelEntries.push_back(new Model::ModelEntry(mScene->mMeshes[i]));
}

void Model::Clear()
{
	for(int i = 0; i < modelEntries.size(); i++)
		delete modelEntries.at(i);


	modelEntries.clear();
}

void Model::mIstantiate()
{
	for(int i = 0; i < modelEntries.size(); i++)
		modelEntries.at(i)->mIstantiate();
}