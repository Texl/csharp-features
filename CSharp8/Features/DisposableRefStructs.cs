using System;

namespace CSharp8.Features
{
    public static class DisposableRefStructs
    {
        private static class ArrayPool
        {
            public static int Acquire(int size) => throw new NotImplementedException();

            public static void Release(int handle) => throw new NotImplementedException();
        }
        
        public readonly ref struct ExampleReadonlyRefStruct
        {
            public readonly int Size;
            public readonly int PooledArrayHandle;

            public ExampleReadonlyRefStruct(int size)
            {
                Size = size;
                PooledArrayHandle = ArrayPool.Acquire(size);
            }

            public void Dispose()
            {
                ArrayPool.Release(PooledArrayHandle);
            }
        }
        
        public static void Run()
        {
            using var pooledArray = new ExampleReadonlyRefStruct(100);
            Console.WriteLine(pooledArray.Size);
            
            // pooledArray.Dispose(); here
        }
    }
}
