//////////////////////////////////
//Разработчик: Faridun Berdiev
//****************************
//Имя Файл: Texture.cpp
//******************
//Версия: v0.1.8
//************
//Файл отвечающий за текстурирование
//*****************************************
//////////////////////////////////

#include "stdafx.h"
#include "Texture.h"

#include <map>


#include <assimp/cimport.h>
#include <assimp/scene.h>
#include <assimp/postprocess.h>

#pragma warning(disable : 4996)

using namespace std;

Texture::Texture(void)
{
}


Texture::~Texture(void)
{
}


string Texture::GetBasePath(const string& Path)
{
	size_t Pos = Path.find_last_of("\\/");
	return (string::npos == Pos) ? "" : Path.substr(0, Pos + 1);
}

bool Texture::ai_LoadTexture(GLfloat TexParams, const aiScene* mScene, const string ModelPath)
{
	bool Success;

	if(mScene->HasTextures())
		Log("IMPORTING-STATUS->", "Support for meshes with embedded textures is not implemented", 1);

	for(unsigned int M = 0; M < mScene->mNumMaterials; M++)
	{
		int tTexIndex = 0;

		aiReturn tTexFound = AI_SUCCESS;

		aiString mtPath;

		while(tTexFound == AI_SUCCESS)
		{
			tTexFound = mScene->mMaterials[M]->GetTexture(aiTextureType_DIFFUSE, tTexIndex, &mtPath);
			TextureIDMap[mtPath.data] = NULL;
			tTexIndex++;
		}
	}

	int mNumTextures = TextureIDMap.size();
    

	map<string, GLuint*>::iterator itr = TextureIDMap.begin();

	string BasePath = GetBasePath(ModelPath);

	for(int i = 0; i < mNumTextures; i++)
	{
		string FileName = (*itr).first;
		(*itr).second = &tTexIDS[i];
		itr++;

		string FileLocation = BasePath + FileName;
		Success = LoadTGA(TexParams, (char*)FileLocation.c_str());

		if(Success)
		{
			return true;
		}
		else if(!Success)
		{
			Log("IMPORT-STATUS->CAN'T LOAD TEXTURE: ", FileLocation.c_str(), 1);
			return false;
		}
	}

	return true;
}

bool Texture::LoadTGA(GLfloat TexParams, 
					  char TexName[256])
{
    GLubyte TGAheader[12]={0,0,2,0,0,0,0,0,0,0,0,0};                    
    GLubyte TGAcompare[12];                                             
    GLubyte header[6];                                           
    GLuint  bytesPerPixel;                                        
    GLuint  imageSize;                                                    
    GLuint  temp;                                                          
    GLuint  type = GL_RGBA;                                                 
    FILE *file = fopen(TexName, "rb");                                   
    if( file==NULL ||                                                       
    fread(TGAcompare,1,sizeof(TGAcompare),file)!=sizeof(TGAcompare) ||    
    memcmp(TGAheader,TGAcompare,sizeof(TGAheader))!=0               ||     
    fread(header,1,sizeof(header),file)!=sizeof(header))                  
    {
        if (file == NULL)                                            
        {
            Log("TEXTURE->" ,"CAN'T FIND FILE", 1);
            return false;                                              
        }
            if(TGAcompare[2] == 1)
                Log("TEXTURE->", "Image cannot be indexed color. \r\n Convert the image to RGB or RGBA", 1);
            if(TGAcompare[2] == 3)
                Log("TEXTURE->", "Image cannot be greyscale color. \r\n Convert the image to RGB or RGBA", 1);
            if(TGAcompare[2] == 9 || TGAcompare[2] == 10)
                Log("TEXTURE->", "Image cannot be compressed. \r\n Convert the image to an uncompressed format", 1);
            fclose(file);                                                  
            return false;                                                  
        }
        tWidth  = header[1] * 256 + header[0];               
        tHeight = header[3] * 256 + header[2];                   
        if(tWidth  <=0     ||                                      
        tHeight <=0     ||                                       
        (header[4]!=24 && header[4]!=32))                              
        {
            fclose(file);                                    
            if(tWidth  <=0 || tHeight  <=0)
                Log("TEXTURE->", "Image must have a width and height greater than 0", 1);
            if(header[4]!=24 && header[4]!=32)
                Log("TEXTURE->", "Image must be 24 or 32 bit", 1);
            return false;                                             
        }
        tBpp    = header[4];                                      
        bytesPerPixel   = tBpp/8;                                  
        imageSize       = tWidth*tHeight*bytesPerPixel;    
        ImageData = (GLubyte*)malloc(imageSize);                    
        if( ImageData == NULL ||                              
        fread(ImageData, 1, imageSize, file)!=imageSize)           
        {
            if(ImageData!=NULL)                                  
                free(ImageData);                                   
            Log("TEXTURE->", "Image load failed for unknown reason", 1);
            fclose(file);                                                  
            return false;                                                
        }
        for(GLuint i=0; i<(GLuint)imageSize; i+=bytesPerPixel)                
        {                                                                   
            temp = ImageData[i];                                 
            ImageData[i] = ImageData[i + 2];   
            ImageData[i + 2] = (GLubyte)temp; 
        }
        fclose (file);

		glGenTextures(1, &tTexID); 
        glBindTexture(GL_TEXTURE_2D, tTexID);

		glTexParameterf(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, TexParams);
        glTexParameterf(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, GL_LINEAR_MIPMAP_LINEAR);
		glTexParameterf(GL_TEXTURE_CUBE_MAP, GL_TEXTURE_MAG_FILTER, TexParams);
		glTexParameterf(GL_TEXTURE_CUBE_MAP, GL_TEXTURE_MIN_FILTER, GL_LINEAR_MIPMAP_LINEAR);
        glTexParameterf(GL_TEXTURE_CUBE_MAP, GL_TEXTURE_WRAP_S, GL_CLAMP_TO_EDGE);
        glTexParameterf(GL_TEXTURE_CUBE_MAP, GL_TEXTURE_WRAP_T, GL_CLAMP_TO_EDGE);
        glTexParameterf(GL_TEXTURE_CUBE_MAP, GL_TEXTURE_WRAP_R, GL_CLAMP_TO_EDGE);

	    glGenerateMipmap(GL_TEXTURE_2D);

        if (tBpp==24) 
        {
            type=GL_RGB; 
        }
        glTexEnvf(GL_TEXTURE_ENV, GL_TEXTURE_ENV_MODE, GL_MODULATE);
        glTexImage2D(GL_TEXTURE_2D, 0, type, tWidth, tHeight, 0, type, GL_UNSIGNED_BYTE, ImageData);
        gluBuild2DMipmaps(GL_TEXTURE_2D, type, tWidth, tHeight, type, GL_UNSIGNED_BYTE, ImageData);
        free(ImageData);
        return true;
}