#include <windows.h>

#include "debugConnector.h"

bool IsDataAvailable()
{
    return dc_isDataAvailable;
}

void SetInt(int value)
{
    if (dc_isDataAvailable)
        return;
    
    dc_isDataAvailable = true;
    dc_value = value;
}

int GetInt()
{
    if (!dc_isDataAvailable)
        return 0;
    
    dc_isDataAvailable = false;
    return dc_value;
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

