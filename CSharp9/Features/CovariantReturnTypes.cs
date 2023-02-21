using System;
using System.IO;

namespace CSharp9.Features
{
   public static class CovariantReturnTypes
   {
      public abstract class BaseClass
      {
         public virtual Stream GetStream() => throw new NotImplementedException();
      }

      public sealed class DerivedClass : BaseClass
      {
         // GetStream() in the derived type can differ in the return type so long as it's derived from the base's return type  
         public override FileStream GetStream() => throw new NotImplementedException();
      }
   }
}
