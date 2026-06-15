using System.IO;
using System;
namespace Patterns.Structural.Adapter
{
    public class FileLogger
    {
        static string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private readonly string _filePath =  Path.Combine(desktopPath, "myLogger.txt");
        public void WriteLine(string text, int level)
        {
            using (StreamWriter sw = new StreamWriter(_filePath, true))
            {
                sw.WriteLine($"Level: {level} - {text}");
            }
        }
    }
}