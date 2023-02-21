using System;

namespace CSharp9.Features
{
   public sealed class ExampleAttribute : Attribute
   {
      public ExampleAttribute(string value)
      {
      }
   }
   
   public static class LocalFunctionAttributes
   {
      [Example("class static function")]
      public static void Example()
      {
         [Example("local function")]
         int Area(int width, int height) => width * height;

         [Example("local static function")]
         static int AreaStatic(int width, int height) => width * height;
      }
   }
}
