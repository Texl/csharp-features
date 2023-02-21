using System.IO;

namespace CSharp8.Features
{
    public static class UsingDeclarations
    {
        public static string CSharp7()
        {
            using (var stream = new StreamReader("file.txt"))
            {
                return stream.ReadToEnd();
            }
        }

        public static string CSharp8()
        {
            using var stream = new StreamReader("file.txt");
            return stream.ReadToEnd();
        }
    }
}
