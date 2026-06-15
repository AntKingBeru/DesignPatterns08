using UnityEngine;

namespace Patterns.Structural.Adapter
{
    public class WhatsappLogger
    {
        // ? text = 
        private const string WHATS_APP_LINK = "https://wa.me/";
        private const string MY_NUMBER = "972546969208";
        
        public void WriteLine(string text, int level)
        {
            Application.OpenURL($"{WHATS_APP_LINK}{MY_NUMBER}?text={text}");
        }
    }
}