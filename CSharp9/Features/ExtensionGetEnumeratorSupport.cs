using System;
using System.Collections.Generic;

namespace CSharp9.Features
{
   public sealed class CustomEnumerable<T> {}

   public static class CustomEnumerableExtensions
   {
      public static IEnumerator<T> GetEnumerator<T>(this CustomEnumerable<T> enumerable) =>
         throw new NotImplementedException();
   }

   public static class ExtensionGetEnumeratorSupport
   {
      public static void Example()
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
}
