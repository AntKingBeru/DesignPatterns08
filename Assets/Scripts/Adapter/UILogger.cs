namespace Patterns.Structural.Adapter
{
    public class UILogger
    {
        public void WriteLine(string text, int level)
        {
            GameManager.Instance.textField.text += $"\n[{level}] {text}";
        }
    }
}