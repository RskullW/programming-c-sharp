using System;
using System.Runtime.InteropServices;

namespace ConsoleApplication1
{
    public static class NewArray
    {
        // Connect DLL File
        [DllImport("EazyPeazyArray.dll", EntryPoint = "InputArray", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InputArray(int[] array, int size); 
        [DllImport("EazyPeazyArray.dll", EntryPoint = "OutputArray", CallingConvention = CallingConvention.Cdecl)]
        public static extern void OutputArray(int[] array, int size);
        [DllImport("EazyPeazyArray.dll", EntryPoint = "SetArray", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetArray(int[] array, int size);
    }
}