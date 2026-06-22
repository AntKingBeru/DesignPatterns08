using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerStatsView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI levelText;
    [SerializeField] private TextMeshProUGUI coinsText;
    [SerializeField] private TextMeshProUGUI upgradeCostText;
    [SerializeField] private Button upgradeButton;
    [SerializeField] private Button coinButton;
    
    public Button UpgradeButton => upgradeButton;
    
    public void ShowLevel(int level)
    {
        levelText.text = $"Level: {level}";
    }

    public void ShowCoins(int coins)
    {
        coinsText.text = $"Coins: {coins}";
    }

    public void ShowUpgradeCost(int cost)
    {
        upgradeCostText.text = $"Upgrade cost: {cost}";
    }

    public void SetUpgradeButtonEnabled(PlayerStatsModel model)
    {
        upgradeButton.interactable = model.CanUpgrade();
    }
}