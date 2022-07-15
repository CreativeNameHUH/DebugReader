#include <windows.h>
#include <fstream>
#include <tchar.h>

#include "debugServer.h"
#include "budgetLock.h"

int Initialize()
{
    Lock::Close();
    {
        ds_handle = CreateFileMapping(INVALID_HANDLE_VALUE, nullptr, PAGE_READWRITE, 0, BUFFER_SIZE, ds_name);

        if (!ds_handle)
        {
            Lock::Open();
            return 1;
        }

        ds_buffer = static_cast<LPCTSTR>(MapViewOfFile(ds_handle, FILE_MAP_ALL_ACCESS, 0, 0, BUFFER_SIZE));

        if (!ds_buffer)
        {
            Lock::Open();
            return 2;
        }
    }
    Lock::Open();
    return 0;
}

int Terminate()
{
    Lock::Close();
    {
        UnmapViewOfFile(ds_buffer);
        CloseHandle(ds_handle);
    }
    Lock::Open();
    return 0;
}

void SendData(const char* data, int dataLength)
{
    Lock::Close();
    {
        CopyMemory((PVOID)ds_buffer, test, (_tcslen(test) * sizeof(TCHAR)));
    }
    Lock::Open();
}


BOOL APIENTRY DllMain(HMODULE hModule, DWORD  ul_reason_for_call, LPVOID lpReserved)
{
    switch (ul_reason_for_call)
    {
    case DLL_PROCESS_ATTACH:
    case DLL_THREAD_ATTACH:
    case DLL_THREAD_DETACH:
    case DLL_PROCESS_DETACH:
        break;
    }
	
    return TRUE;
}

