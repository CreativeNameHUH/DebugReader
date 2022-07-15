#pragma once

#ifdef DEBUG_SERVER_EXPORT
#define DEBUG_SERVER_API __declspec(dllexport)
#else
#define DEBUG_SERVER_API __declspec(dllimport)
#endif

#define BUFFER_SIZE 256

// Data:
const TCHAR ds_name[] = TEXT("Global\\DebugObject");
static HANDLE ds_handle = nullptr;
static LPCTSTR ds_buffer = nullptr;

// Functions:
extern "C" DEBUG_SERVER_API int __stdcall Initialize(void);
extern "C" DEBUG_SERVER_API int __stdcall Terminate(void);

extern "C" DEBUG_SERVER_API void __stdcall SendData(const char* data, int dataLength);
