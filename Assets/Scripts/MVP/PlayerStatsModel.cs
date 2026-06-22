using UnityEngine;

public class PlayerStatsModel
{
    public int Level { get; private set; }
    public int Coins { get; private set; }
    public int UpgradeCost { get; private set; }

    public PlayerStatsModel(int startCoins = 0)
    {
        Coins = startCoins;
        UpgradeCost = 1;
    }

    public bool CanUpgrade() => Coins >= UpgradeCost;
    
    public void Upgrade()
    {
        Coins -= UpgradeCost;
        Level++;
        UpgradeCost = (int)Mathf.Pow(2, Level);
    }

    public void AddCoin()
    {
        Coins++;
    }
}