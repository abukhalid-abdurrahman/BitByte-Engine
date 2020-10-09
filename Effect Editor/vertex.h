// Vertex Class    by Alan Baylis 2001

#ifndef VertexH
#define VertexH

#include "vector.h"

class VERTEX
{
    public:
          VERTEX(float x = 0, float y = 0, float z = 0, float nx = 0, float ny = 0, float nz = 0);
          ~VERTEX();

          VECTOR coords;
          VECTOR normal;
        float u;
        float v;

// operator overloading
        VERTEX& operator = (const VERTEX& Vertex)
        {
            coords = Vertex.coords;
            normal = Vertex.normal;
            u = Vertex.u;
            v = Vertex.v;
            return *this; 
        }
};

#endif

