namespace CSharp9.Features
{
   public static class TargetTypedConditionalExpressions
   {
      public static void Example(bool condition)
      {
         // This doesn't compile in C# 8 because neither of '0' and 'null' are of the target type 'int?".
         int? boolExpression = condition ? 0 : null;
      }
   }
}
