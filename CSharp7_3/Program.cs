using System;

namespace CSharp7_3
{
    public struct ExampleStruct
    {
        public int Field1;
        public int Field2;

        public int Sum() => Field1 + Field2;

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
