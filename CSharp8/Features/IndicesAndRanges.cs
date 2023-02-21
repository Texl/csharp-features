using System.Collections.Generic;
using System.Linq;

namespace CSharp8.Features
{
    public static class IndicesAndRanges
    {
        private static readonly int[] Array = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
        
        public static void CSharp7()
        {
            int first = Array[0];

            int last = Array[Array.Length - 1];

            // 0 1 2
            int[] frontSlice = Array.Take(3).ToArray();
            // 3 4 5 6
            int[] midSlice = Array.Skip(3).Take(4).ToArray();
            // 7 8 9
            int[] backSlice = Array.Skip(Array.Length - 3).ToArray();
        }

        public static void CSharp8()
        {
            int first = Array[0];

            int last = Array[^1];

            // 0-2
            int[] frontSlice = Array[..3];
            // 3-6
            int[] midSlice = Array[4..7];
            // 7-9
            int[] backSlice = Array[^3..];
        }
    }
}
