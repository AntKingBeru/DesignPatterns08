using System.IO;
using System;
namespace Patterns.Structural.Adapter
{
    public class FileLogger
    {
        private static string _desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private readonly string _filePath =  Path.Combine(_desktopPath, "myLogger.txt");
        public void WriteLine(string text, int level)
        {
            using (StreamWriter sw = new StreamWriter(_filePath, true))
            {
                sw.WriteLine($"Level: {level} - {text}");
            }
        }
    }
}