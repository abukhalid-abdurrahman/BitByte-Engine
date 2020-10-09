#ifndef PolygonH
#define PolygonH

#include "polygon.h"
#include "Texture.h"
#include "vertex.h"

class POLYGON
{
    public:
        POLYGON();
          ~POLYGON();

                VECTOR GetNormal();
                void SetNormal();

          Texture tiTexture;
          VERTEX Vertex[3];
        int numVertices;
};

#endif
