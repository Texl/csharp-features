using System;

namespace CSharp9.Features
{
   public static class Records
   {
      public record Rectangle(double Width, double Height);

      public record RectangleEquivalent
      {
         public double Width { get; init; }
         public double Height { get; init; }
      }

      public static void Examples()
      {
         // built-in structural / value equality 
         Rectangle rect1 = new(1, 2);
         Rectangle rect2 = new(1, 2);
         Console.WriteLine(rect1 == rect2); // true
         
         // immutable by default
         Rectangle rect3 = new(4, 8);
         //rect3.Width = 5; // compile error
         
         // Microsoft terms this "non-destructive mutation" - sounds odd to me.
         // F# calls this a "copy and update" operation
         Rectangle rect4 = rect1 with {Width = 3};
         Rectangle rect5 = new(1, 3);
         Console.WriteLine(rect4 == rect5); // true
      }
   }
}
