#pragma once

#ifdef DEBUG_CLIENT_EXPORT
#define DEBUG_CLIENT_API __declspec(dllexport)
#else
#define DEBUG_CLIENT_API __declspec(dllimport)
#endif

#define BUFFER_SIZE 256

// Data:
const TCHAR dc_name[] = TEXT("Global\\DebugObject");
static HANDLE dc_handle = nullptr;
static LPCTSTR dc_buffer = nullptr;

// Functions:
extern "C" DEBUG_CLIENT_API int Initialize(void);
extern "C" DEBUG_CLIENT_API int Terminate(void);

extern "C" DEBUG_CLIENT_API const char* GetData(void);