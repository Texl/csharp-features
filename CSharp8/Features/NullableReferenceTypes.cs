// Once opted in, reference types are non-nullable by default 
#nullable enable

namespace CSharp8.Features
{
    public static class NullableReferenceTypes
    {
        public static void CSharp8(string neverNullInput, string? mightBeNullInput)
        {
            // ok - same nullability
            string neverNull1 = neverNullInput;
            
            // compile warning - lhs is non-nullable, but parameter might be null 
            string neverNull2 = mightBeNullInput;

            // compiles without warning, but there's information loss
            string? mightBeNull1 = neverNullInput;

            // ok - same nullability
            string? mightBeNull2 = mightBeNullInput;
        }
    }
}
