namespace CSharp8.Features
{
    public static class NullCoalescingAssignment
    {
        public static string CSharp7(string input)
        {
            string str = input;
            str = str ?? "default";
            return str;
        }
        
        public static string CSharp8(string input)
        {
            // null-coalescing assignment (??=)
            string str = input;
            str ??= "default";
            return str;
        }
    }
}
