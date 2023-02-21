namespace CSharp8.Features
{
    public struct ReadOnlyMemberStruct
    {
        public int Field1;
        public int Field2;

        // Signals compiler that no defensive copy is needed
        public readonly int Sum() => Field1 + Field2;
        
        public ReadOnlyMemberStruct(int field1, int field2)
        {
            Field1 = field1;
            Field2 = field2;
        }
    }
}
