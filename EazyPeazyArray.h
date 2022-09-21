#pragma once
#include <fstream>
#include <string>
#include <iostream>
#ifdef FILE32_EXPORTS
#define DLL_EXPORT __declspec(dllexport)
#else
#define DLL_EXPORT __declspec(dllimport)
#endif


#ifdef __cplusplus
extern "C"
{
#endif
    using namespace std;
    //int DLL_EXPORT open();
    //int DLL_EXPORT open(wchar_t  * , bool );
    DLL_EXPORT void InputArray(int*, int);
    DLL_EXPORT void OutputArray(int*, int);
    DLL_EXPORT void SetArray(int*, int);

#ifdef __cplusplus
}
#endif
