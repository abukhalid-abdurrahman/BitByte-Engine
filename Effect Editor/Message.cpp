//////////////////////////////////
//Разработчик: Faridun Berdiev
//****************************
//Имя Файл: Message.cpp
//******************
//Версия: v0.1.8
//************
//Класс отвечающий за сообщиние от FGE : EE
//*****************************************
//////////////////////////////////

#include "stdafx.h"
#include "Message.h"

void Log(string Title, string Message, int Count)
{
	for(int i = 0; i < Count; i++) 
		cout << Title << Message << endl;
}

void MessageDialogDefault(string Title, string Message, UINT MessageType, int Count)
{
	for(int i = 0; i < Count; i++)
		MessageBox(NULL, Message.c_str(), Title.c_str(), MessageType);
}
