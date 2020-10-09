#ifndef CameraH
#define CameraH

#include "object.h"
#include "matrix.h"

class CAMERA : public OBJECT
{
    public:
        CAMERA();
        ~CAMERA();
                
        void Reset();
        void Update();
        void Apply();

        MATRIX Matrix;
};

#endif

