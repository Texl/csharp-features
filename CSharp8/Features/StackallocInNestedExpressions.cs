using System;

namespace CSharp8.Features
{
    public static class StackAllocInNestedExpressions
    {
        public static void CSharp7(string input)
        {
            // stackalloc'd array has to be created here
            ReadOnlySpan<char> characters = stackalloc char[] {' ', '\r', '\n'};
            var trimmed = input.AsSpan().Trim(characters).ToString();
        }


        public static void CSharp8(string input)
        {
            // stackalloc'd array can be created in the expression
            var trimmed = input.AsSpan().Trim(stackalloc[] {' ', '\r', '\n'}).ToString();
        }
    }
}
