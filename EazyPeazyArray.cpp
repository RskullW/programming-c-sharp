#include "EazyPeazyArray.h"
#include "iostream"
#include <stdlib.h>
#include <time.h>

void InputArray(int* array, unsigned int size) {
    for (int i = 0; i < size; ++i) {
        srand(time(NULL));
        *(array+size) = rand()%1000;
    }
}
void OutputArray(int* array, unsigned int size) {
    std::cout << "\nOutput array(" << size << "):\n";
    for (int i = 0; i < size; ++i) {
        std::cout << *(array + i) << " ";
    }
}
void SetArray(int* array, unsigned int size) {
    for (int i = 0; i < size; ++i) {
        *(array + i) = (*(array+i)%3==0)?1:(*array+i);
    }
}