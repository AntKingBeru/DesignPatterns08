using UnityEngine;

public class PlayerStatsScreen : MonoBehaviour
{
    [SerializeField] private int startCoins;
    [SerializeField] private PlayerStatsView view;
    private PlayerStatsPresenter _presenter;

    private void Start()
    {
        var model = new PlayerStatsModel(startCoins);
        _presenter = new PlayerStatsPresenter(model, view);
    }
}