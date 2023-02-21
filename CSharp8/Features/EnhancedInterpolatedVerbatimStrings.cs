using System;

namespace CSharp8.Features
{
    public static class EnhancedInterpolatedVerbatimStrings
    {
        // Interpolated ($) and verbatim (@) string prefixes work in either order now
        public static readonly string CSharp7 = $@"C:\Users\{Environment.UserName}\Desktop";
        public static readonly string CSharp8 = @$"C:\Users\{Environment.UserName}\Desktop";
    }
}
