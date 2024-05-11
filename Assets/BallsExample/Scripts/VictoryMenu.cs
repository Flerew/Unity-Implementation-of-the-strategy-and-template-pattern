using UnityEngine;
using UnityEngine.UI;

public class VictoryMenu : MonoBehaviour
{
    [SerializeField] private Button _goToMainMenuButton;
    [SerializeField] private Button _restartButton;
    [SerializeField] private GameMediator _gameMediator;

    private void OnEnable()
    {
        _goToMainMenuButton.onClick.AddListener(GoToMainMenu);
        _restartButton.onClick.AddListener(RestartLevel);
    }

    private void OnDisable()
    {
        _goToMainMenuButton.onClick.RemoveListener(GoToMainMenu);
        _restartButton.onClick.RemoveListener(RestartLevel);
    }

    private void GoToMainMenu()
    {
        _gameMediator.GoToMainMenu();
    }

    private void RestartLevel()
    {
        _gameMediator.RestartLevel();
    }
}
