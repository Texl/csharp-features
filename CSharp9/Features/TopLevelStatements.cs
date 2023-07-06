using System;

void ExplainTopLevelStatements()
{
    Console.WriteLine("Top-level Statements");
    Console.WriteLine();
    Console.WriteLine("This is the program's main function.");
    Console.WriteLine("C# 9 allows you to elide most of the boilerplate that usually surrounds it.");
}

void RunGeneratedSource()
{
    // Added via source generator
    HelloWorldGenerated.HelloWorld.SayHello();
}

Console.WriteLine("C# 9");
ExplainTopLevelStatements();
RunGeneratedSource();
