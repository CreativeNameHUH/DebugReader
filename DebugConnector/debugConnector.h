#pragma once

#ifdef DEBUG_CONNECTOR_EXPORT
#define DEBUG_CONNECTOR_API __declspec(dllexport)
#else
#define DEBUG_CONNECTOR_API __declspec(dllimport)
#endif

// Test functions
extern "C" DEBUG_CONNECTOR_API static void SendInt(int value);
extern "C" DEBUG_CONNECTOR_API static int GetInt();

extern "C" DEBUG_CONNECTOR_API static bool IsDataAvailable();

// Data:
static bool dc_isDataAvailable = false;
static int dc_value = 0;