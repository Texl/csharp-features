using System;

namespace CSharp8.Features
{
    public static class UnmanagedConstructedTypes
    {
        private struct Coords<T> where T : unmanaged
        {
            public T X;
            public T Y;
        }
        
        private static unsafe void PrintSizeOf<T>() where T : unmanaged
        {
            Console.WriteLine(sizeof(T));
        }

        public static void CSharp8()
        {
            // Coords<T> isn't considered an "unmanaged type" in C# 7, so it won't compile when used in an unsafe context. 
            PrintSizeOf<Coords<int>>();
        }
    }
}
