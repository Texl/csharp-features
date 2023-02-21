using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;

namespace CSharp9.Features
{
   public static class FitAndFinishFeatures
   {
      public static void TargetTypedNewExpressions()
      {
         // Can elide the type after 'new' if it's inferrable from the left  

         Vector2 vOld = new Vector2(4, 8);
         Vector2 vNew = new(4, 8);
      }

      public static void StaticAnonymousFunctions(int multiplier)
      {
         // Like static local functions - static anonymous functions can't capture

         int result1 = Enumerable.Range(0, 10).Min(x => multiplier * x);
         // int result2 = Enumerable.Range(0, 10).Min(static x => multiplier * x); // compile error
      }

      public static void ConditionalExpressionConversion(bool condition)
      {
         // This doesn't compile in C# 8 because neither of '0' and 'null' are of the target type 'int?".
         int? boolExpression = condition ? 0 : null;
      }

      public static void LambdaDiscards()
      {
         // Prior to C# 9, underscores in this context were actually just identifiers, not discards - the compiler
         // would complain if you had multiple "discards" in scope.
         Func<int, int, int> contrivedFunction = (_, _) => 0;
      }
   }


   public static class CovariantReturnTypes
   {
      public abstract class BaseClass
      {
         public virtual Stream GetStream() => throw new NotImplementedException();
      }

      public sealed class DerivedClass : BaseClass
      {
         // GetStream() in the derived type can differ in the return type so long as it's derived from the base's return type  
         public override FileStream GetStream() => throw new NotImplementedException();
      }
   }

   public sealed class CustomEnumerable<T> {}

   public static class CustomEnumerableExtensions
   {
      public static IEnumerator<T> GetEnumerator<T>(this CustomEnumerable<T> enumerable) =>
         throw new NotImplementedException();
   }

   public static class ExtensionGetEnumeratorSupport
   {
      public static void Usage()
      {
         var customEnumerable = new CustomEnumerable<int>();

         // Prior to C# 9, this would only work if CustomEnumerable implemented IEnumerable<T>.
         // With C# 9 there's also the option to implement GetEnumerator() as an extension method.
         foreach (int enumeratedValue in customEnumerable)
         {
            Console.WriteLine($"enumeratedValue");
         }
      }
   }

   public sealed class ExampleAttribute : Attribute
   {
      public ExampleAttribute(string value)
      {
      }
   }
   
   public static class LocalFunctionAttributes
   {
      [Example("class static function")]
      public static void Usage()
      {
         [Example("local function")]
         int Area(int width, int height) => width * height;

         [Example("local static function")]
         static int AreaStatic(int width, int height) => width * height;
      }
   }
}
