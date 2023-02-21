using System;
using System.Numerics;

namespace CSharp8.Features
{
    public static class StaticLocalFunctions
    {
        // Static local functions can't capture anything from local scope - this can cut down a good bit on closure allocations
        
        public static void CSharp7(Vector3 xyz)
        {
            double Length(Vector2 xy)
            {
                // xyz is captured
                return Math.Sqrt(xyz.X * xyz.X + xy.Y * xy.Y);
            }
        }
        
        public static void CSharp8(Vector3 xyz)
        {
            static double Length(Vector2 xy)
            {
                // static local is unable to capture xyz - compile error
                // return Math.Sqrt(xyz.X * xyz.X + xy.Y * xy.Y);

                return Math.Sqrt(xy.X * xy.X + xy.Y * xy.Y);
            }
        }
    }
}
