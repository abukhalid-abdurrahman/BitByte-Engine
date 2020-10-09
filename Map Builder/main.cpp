#include "stdafx.h"
#include "resource.h"
#include <GL/gl.h>

const char ClassName[] = "MainWindowClass";
const char ChildClassName[] = "ChildWindowClass";

HWND hWndClient;

void ReleaseGLContexts(HWND hWnd, HDC hDC, HGLRC hRC)
{
    ChangeDisplaySettings(NULL, 0);
    wglMakeCurrent(hDC, NULL);
    wglDeleteContext(hRC);
    ReleaseDC(hWnd, hDC);
}



LRESULT CALLBACK ChildProc(HWND hWnd,
                           UINT Msg,
                           WPARAM wParam,
                           LPARAM lParam)
{
    switch(Msg)
    {
        //Child Message
    }

    return DefMDIChildProc(hWnd, Msg, wParam, lParam);
}

LRESULT CALLBACK WndProc(HWND hWnd,
                         UINT Msg,
                         WPARAM wParam,
                         LPARAM lParam)
{
    switch (Msg)
    {
        case WM_CREATE:
        {
            CLIENTCREATESTRUCT ccs;
            ccs.hWindowMenu  = GetSubMenu(GetMenu(hWnd), 0);
            ccs.idFirstChild = ID_MDI_FIRSTCHILD;

            hWndClient = CreateWindowEx(
            WS_EX_CLIENTEDGE,
            "MDICLIENT",
            NULL,
            WS_CHILD | WS_CLIPCHILDREN | WS_VSCROLL | WS_HSCROLL,
            CW_USEDEFAULT,
            CW_USEDEFAULT,
            CW_USEDEFAULT,
            CW_USEDEFAULT,
            hWnd,
            (HMENU)ID_MDI_CLIENT,
            (HINSTANCE)GetWindowLong(hWnd, GWL_HINSTANCE),
            (LPVOID)&ccs);

            if(!hWndClient)
            {
                MessageBox(hWnd, "Failed To Create The Client Window", "Error", MB_OK);
            }

            ShowWindow(hWndClient, SW_SHOW);
        }
        break;

        case WM_COMMAND:
        {
            switch(LOWORD(wParam))
            {
                case IDM_FILE_EXIT:
                    PostMessage(hWnd, WM_CLOSE, 0, 0);
                break;

                case IDM_NEW_MAP:
                {
                    HWND hChild;
                    CREATESTRUCT cs;
                    ZeroMemory(&cs, sizeof(CREATESTRUCT));
                    hChild = CreateWindowEx(
                    WS_EX_MDICHILD,
                    ChildClassName,
                    "3D Scene",
                    WS_CHILD | WS_VISIBLE | WS_OVERLAPPEDWINDOW,
                    CW_USEDEFAULT,
                    CW_USEDEFAULT,
                    600,
                    400,
                    hWndClient,
                    NULL,
                    (HINSTANCE)GetWindowLong(hWnd, GWL_HINSTANCE),
                    &cs);

                    if(!hChild)
                        MessageBox(hWnd, "Failed To Create The Child Window", "Error", MB_OK);
                }
                break;

                default:
                {
                    if(LOWORD(wParam) >= ID_MDI_FIRSTCHILD)
                        DefFrameProc(hWnd, hWndClient, Msg, wParam, lParam);
                    else
                    {
                        HWND hChild;
                        hChild = (HWND)SendMessage(hWndClient, WM_MDIGETACTIVE,0,0);
                        if(hChild)
                            SendMessage(hChild, WM_COMMAND, wParam, lParam);
                    }
                }
            }
            return 0;
        }
        break;

        case WM_CLOSE:
            DestroyWindow(hWnd);
        break;

        case WM_DESTROY:
            PostQuitMessage(0);
        break;

        default:
            return DefFrameProc(hWnd, hWndClient, Msg, wParam, lParam);
    }

    return 0;
}



INT WINAPI WinMain(HINSTANCE  hInstance,
                   HINSTANCE  hPrevInstance,
                   LPSTR      lpCmdLine,
                   INT        nCmdShow)
{
    InitCommonControls();
    WNDCLASSEX wc;

    wc.cbSize           = sizeof(WNDCLASSEX);
    wc.style            = CS_HREDRAW | CS_VREDRAW;
    wc.lpfnWndProc      = (WNDPROC)WndProc;
    wc.cbClsExtra       = 0;
    wc.cbWndExtra       = 0;
    wc.hInstance        = hInstance;
    wc.hIcon            = LoadIcon(NULL, IDI_APPLICATION);
    wc.hIconSm          = LoadIcon(NULL, IDI_APPLICATION);
    wc.hCursor          = LoadCursor(NULL, IDC_ARROW);
    wc.hbrBackground    = (HBRUSH)(COLOR_WINDOW + 1);
    wc.lpszMenuName     = MAKEINTRESOURCE(IDR_MENU);
    wc.lpszClassName    = ClassName;

    if (!RegisterClassEx(&wc))
    {
        MessageBox(NULL, "Failed To Register The Window Class.", "Error", MB_OK | MB_ICONERROR);
        return 0;
    }

    wc.lpfnWndProc      = (WNDPROC)ChildProc;
    wc.hCursor          = LoadCursor(NULL, IDC_ARROW);
    wc.hbrBackground    = (HBRUSH)(COLOR_3DSHADOW + 1);
    wc.lpszMenuName     = NULL;
    wc.lpszClassName    = ChildClassName;

    if(!RegisterClassEx(&wc))
    {
        MessageBox(NULL, "Failed To Register The Child Window Class", "Error", MB_OK | MB_ICONERROR);
        return 0;
    }

    HWND hWnd;
    hWnd = CreateWindowEx(
    WS_EX_CLIENTEDGE,
    ClassName,
    "Faridun's Game Engine. Map Builder!",
    WS_OVERLAPPEDWINDOW,
    CW_USEDEFAULT,
    CW_USEDEFAULT,
    800,
    600,
    NULL,
    NULL,
    hInstance,
    NULL);

    if (!hWnd)
    {
        MessageBox(NULL, "Window Creation Failed.", "Error", MB_OK | MB_ICONERROR);
        return 0;
    }

    ShowWindow(hWnd, SW_SHOW);

    UpdateWindow(hWnd);

    MSG Msg;
    while (GetMessage(&Msg, NULL, 0, 0))
    {
        if (!TranslateMDISysAccel(hWndClient, &Msg))
        {
            TranslateMessage(&Msg);
            DispatchMessage(&Msg);
        }
    }

    return Msg.wParam;
}
