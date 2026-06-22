public class PlayerStatsPresenter
{
    private readonly PlayerStatsModel _model;
    private readonly PlayerStatsView _view;
    
    public PlayerStatsPresenter(PlayerStatsModel model, PlayerStatsView view)
    {
        _model = model;
        _view = view;
        _view.SetUpgradeButtonEnabled(_model);
        _view.UpgradeButton.onClick.AddListener(OnUpgradeClicked);
        RefreshView();
    }

    private void OnUpgradeClicked()
    {
        _model.Upgrade();
        RefreshView();
    }

    private void RefreshView()
    {
        _view.ShowLevel(_model.Level);
        _view.ShowCoins(_model.Coins);
        _view.ShowUpgradeCost(_model.UpgradeCost);
        _view.SetUpgradeButtonEnabled(_model);
    }
}