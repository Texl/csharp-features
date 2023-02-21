using System.Linq;

namespace CSharp9.Features
{
   public static class StaticAnonymousFunctions
   {
      public static void Example(int multiplier)
      {
         // Like static local functions - static anonymous functions can't capture

         int result1 = Enumerable.Range(0, 10).Min(x => multiplier * x);
         // int result2 = Enumerable.Range(0, 10).Min(static x => multiplier * x); // compile error
      }
   }
}
