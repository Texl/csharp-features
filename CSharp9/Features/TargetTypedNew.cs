using System.Numerics;

namespace CSharp9.Features
{
   public static class TargetTypedNewExpressions
   {
      public static void Example()
      {
         // Can elide the type after 'new' if it's inferrable from the left  

         Vector2 vOld = new Vector2(4, 8);
         Vector2 vNew = new(4, 8);
      }
   }
}
