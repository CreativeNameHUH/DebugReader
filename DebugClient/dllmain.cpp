#include <windows.h>
#include <comdef.h>


#include "debugClient.h"

int Initialize()
{
    const HANDLE dc_handle = OpenFileMapping(FILE_MAP_ALL_ACCESS, FALSE, dc_name);

    if (!dc_handle)
        return 1;

    LPCTSTR pBuffer = static_cast<LPCTSTR>(MapViewOfFile(dc_handle, FILE_MAP_ALL_ACCESS, 0, 0, BUFFER_SIZE));

    if (!pBuffer)
    {
        CloseHandle(dc_handle);
        return 2;
    }

    return 0;
}

int Terminate()
{
    if (dc_handle)
        CloseHandle(dc_handle);

    /*if (dc_buffer)
        delete dc_buffer;*/

    return 0;
}

const char* GetData()
{
    if (!dc_handle)
        return "Handle is null";

    const LPCTSTR pBuffer = static_cast<LPCTSTR>(MapViewOfFile(dc_handle, FILE_MAP_ALL_ACCESS, 0, 0, BUFFER_SIZE));
    const char* data = _bstr_t(pBuffer);

    UnmapViewOfFile(pBuffer);
    return data;
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

