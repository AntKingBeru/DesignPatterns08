using UnityEngine;

namespace Patterns.Structural.Adapter
{
    public class ConsoleLogger
    {
        public void WriteLine(string text, int level)
        {
            Debug.Log($"[{level}] {text}");
        }
    }
}