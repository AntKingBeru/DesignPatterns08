using UnityEngine;
using TMPro;

namespace Patterns.Structural.Adapter
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }
        
        public TextMeshProUGUI textField;

        private ILogger _logger;

        private void Awake()
        {
            if (Instance && Instance != this)
            {
                Destroy(gameObject);
                return;
            }
            Instance = this;
            
            _logger = new LoggerAdapter();
        }

        public void LogToConsole(string message)
        {
            _logger.Log(message, LoggerType.Console);
        }
        
        public void LogToUI(string message)
        {
            _logger.Log(message, LoggerType.UI);
        }
        
        public void LogToFile(string message)
        {
            _logger.Log(message, LoggerType.File);
        }
        
        public void LogToWhatsapp(string message)
        {
            _logger.Log(message, LoggerType.Whatsapp);
        }
    }
}