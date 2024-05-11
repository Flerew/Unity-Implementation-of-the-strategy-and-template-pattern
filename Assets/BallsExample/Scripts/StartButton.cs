using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class StartButton : MonoBehaviour
{
    [SerializeField] private GameMode _gameMode;
    [SerializeField] private int _levelSceneID;

    private SceneLoadMediator _sceneLoader;

    [Inject]
    private void Construct(SceneLoadMediator sceneLoader)
        => _sceneLoader = sceneLoader;

    public void OnClick()
    {
        _sceneLoader.GoToGameplayLevel(new LevelLoadingData(_gameMode.SelectedMode), _levelSceneID);
    }
}
