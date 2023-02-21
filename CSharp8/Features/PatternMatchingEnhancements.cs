namespace CSharp8.Features
{
    public static class PatternMatchingEnhancements
    {
        public sealed class Rectangle
        {
            public double Width { get; }
            public double Height { get; }

            public void Deconstruct(out double width, out double height)
            {
                width = Width;
                height = Height;
            }

            public (double Width, double Height) AsTuple() => (Width, Height);

            public Rectangle()
            {
                Width = 5;
                Height = 10;
            }
        }
        
        // All below are using switch expressions

        // Property pattern
        public static double Area2(Rectangle rectangle) =>
            rectangle switch
            {
                {Width: 0, Height: 0} => 0,
                _ => rectangle.Width * rectangle.Height,
            };

        // Positional pattern (uses Deconstruct)
        public static double Area1(Rectangle rectangle) =>
            rectangle switch
            {
                (double width, double height) => width * height,
            };

        // Tuple pattern
        public static double Area3(Rectangle rectangle) =>
            rectangle.AsTuple() switch
            {
                (double width, double height) => width * height,
            };
    }
}
