using System;
using System.Diagnostics;

namespace CSharp8.Features
{
    // Aimed at reducing the pain of adding new methods to interfaces with existing implementers 

    public static class DefaultInterfaceMethods
    {
        public interface ILogger
        {
            void Log(string level, string message);

            public void LogInfo(string message) => Log("INFO", message);
            
            public void LogWarning(string message) => Log("WARNING", message);
            
            public void LogError(string message) => Log("ERROR", message);
        }

        public sealed class ConsoleLog : ILogger
        {
            void ILogger.Log(string level, string message) => Console.WriteLine($"[{level}] {message}");
        }

        public sealed class DebugLog : ILogger
        {
            void ILogger.Log(string level, string message) => Debug.WriteLine($"[{level}] {message}");
        }
    }
}
