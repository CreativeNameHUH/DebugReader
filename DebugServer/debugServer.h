#pragma once

#ifdef DEBUG_SERVER_EXPORT
#define DEBUG_SERVER_API __declspec(dllexport)
#else
#define DEBUG_SERVER_API __declspec(dllimport)
#endif

#define BUFFER_SIZE 256

// Data:
const TCHAR ds_name[] = TEXT("Global\\DebugObject");
const TCHAR test[] = TEXT("TEST");
static HANDLE ds_handle = nullptr;
static LPCTSTR ds_buffer = nullptr;

// Functions:
extern "C" DEBUG_SERVER_API int Initialize(void);
extern "C" DEBUG_SERVER_API int Terminate(void);

extern "C" DEBUG_SERVER_API void SendData(const char* data, int dataLength);
