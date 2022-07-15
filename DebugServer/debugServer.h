#pragma once

#ifdef DEBUG_SERVER_EXPORT
#define DEBUG_SERVER_API __declspec(dllexport)
#else
#define DEBUG_SERVER_API __declspec(dllimport)
#endif

#define BUFFER_SIZE 256