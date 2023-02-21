namespace CSharp9.Features
{
   public record Rectangle(double Width, double Height);

   public static class PatternMatching
   {
      public static void Examples()
      {
         Rectangle rect = new(23, 42);

         // type pattern
         object o = new();

         string message1 =
            o switch
            {
               Rectangle => "rectangle",
               _ => "unknown",
            };

         // relational patterns <, <=, >, >=
         string message2 =
            rect switch
            {
               {Width: < 5} => "narrow",
               {Width: < 10} => "mostly narrow",
               {Width: < 50} => "ok that's wide",
               _ => "dang, dude",
            };

         // pattern combinators 'and', 'or', 'not' - also parenthesization 
         string message3 =
            rect switch
            {
               {Width: < 2} and {Height: < 2} => "tiny",
               {Height: > 50} => "giraffe",
               not ({Width: < 20} or {Width: > 80}) and {Height: > 10} => "idk",
               _ => "unremarkable"
            };

      }
   }
}
