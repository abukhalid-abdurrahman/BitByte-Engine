#ifndef TextH
#define TextH
class Text
{
public:
	Text(void);
	~Text(void);
	void RenderText3D(void *Font, char *Text, float X, float Y, float Z, float TextWidth);
	void RenderTextObject(void *Font, char *Text, float X, float Y, float Z, float rX, float rY, float rZ, float sX, float sY, float sZ, float TextWidth);
	void RenderText2D(void *Font, char *Text, float X, float Y, float TextWidth);
};
#endif
