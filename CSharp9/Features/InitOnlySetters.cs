namespace CSharp9.Features
{
   public static class InitOnlySetters
   {
      // It's like readonly for properties
      
      public sealed class Rectangle
      {
         public double Width { get; set; }
         public double Height { get; init; }

         public void SetWidth(double width) => Width = width;

         // public void SetHeight(double height) => Height = height; // init-only - compile error
      }

      public static void Create()
      {
         Rectangle rect =
            new Rectangle()
            {
               Width = 4,
               Height = 8,
            };

         rect.Width = 15;
         // rect.Height = 16; // init-only - compile error
      }
   }
}
