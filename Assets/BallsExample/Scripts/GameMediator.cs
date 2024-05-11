using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

public class GameMediator : MonoBehaviour
{
    [SerializeField] private GameObject _victoryMenu;
    private SceneLoadMediator _sceneLoadMediator;
    private LevelLoadingData _levelLoadingData;

    [Inject]
    private void Construct(SceneLoadMediator sceneLoadMediator, LevelLoadingData levelLoadingData)
    {
        _sceneLoadMediator = sceneLoadMediator;
        _levelLoadingData = levelLoadingData;
    }

    public void EnableVictoryUI()
    {
        _victoryMenu.SetActive(true);
    }

    public void GoToMainMenu() => _sceneLoadMediator.GoToMainMenu();
    public void RestartLevel() => _sceneLoadMediator.GoToGameplayLevel(_levelLoadingData, SceneManager.GetActiveScene().buildIndex);
}
