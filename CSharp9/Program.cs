using System;

namespace CSharp9
{
   // Records
   // Init only setters
   // Top-level statements
   // Pattern matching enhancements
   // Performance and interop
   //    Native sized integers
   //    Function pointers
   //    Suppress emitting localsinit flag
   // Fit and finish features
   //    Target-typed new expressions
   //    static anonymous functions
   //    Target-typed conditional expressions
   //    Covariant return types
   //    Extension GetEnumerator support for foreach loops
   //    Lambda discard parameters
   //    Attributes on local functions
   // Support for code generators
   //    Module initializers
   //    New features for partial methods
   // Warning wave 5

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
