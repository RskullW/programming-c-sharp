#include "pch.h"
#include "main.h"
DLL_EXPORT void InputArray(int* array, int size) {
    srand(time(NULL));

    for (int i = 0; i < size; ++i) {
        *(array + i) = rand() % 1000;
    }
}

DLL_EXPORT void OutputArray(int* array, int size)
{
    std::cout << "\nOutput array(" << size << ")\n";
    for (int i = 0; i < size; ++i) {
        std::cout << *(array + i) << " ";
    }
};

DLL_EXPORT void SetArray(int* array, int size) {
    int temp;
    for (int i = 0; i < size; ++i) {
        temp = *(array + i);
        *(array + i) = (temp % 3 == 0) ? 1 : temp;
    }
};