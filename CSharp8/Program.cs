using System;

namespace CSharp8
{
    // Readonly members
    // Default interface methods
    // Pattern matching enhancements:
    //    Switch expressions
    //    Property patterns
    //    Tuple patterns
    //    Positional patterns
    // Using declarations
    // Static local functions
    // Disposable ref structs
    // Nullable reference types
    // Asynchronous streams
    // Indices and ranges
    // Null-coalescing assignment
    // Unmanaged constructed types
    // Stackalloc in nested expressions
    // Enhancement of interpolated verbatim strings

    public struct ExampleStruct
    {
        public int Field1;
        public int Field2;

        public readonly int Sum() => Field1 + Field2;

        public ExampleStruct(int field1, int field2)
        {
            Field1 = field1;
            Field2 = field2;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var structInstance = new ExampleStruct(1, 2);

            structInstance.Field1 = 3;

            var sum = structInstance.Sum();
        }
    }
}
