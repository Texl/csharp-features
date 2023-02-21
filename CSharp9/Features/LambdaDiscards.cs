using System;

namespace CSharp9.Features
{
   public static class LambdaDiscards
   {
      public static void Example()
      {
         // Prior to C# 9, underscores in this context were actually just identifiers, not discards - the compiler
         // would complain if you had multiple "discards" in scope.
         Func<int, int, int> contrivedFunction = (_, _) => 0;
      }
   }
}
