using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoadMediator
{
    private const int MainMenuID = 0;

    private ILevelLoader _levelLoader;
    private ISimpleSceneLoader _simpleSceneLoader;


    public SceneLoadMediator(ILevelLoader levelLoader, ISimpleSceneLoader simpleSceneLoader)
    {
        _levelLoader = levelLoader;
        _simpleSceneLoader = simpleSceneLoader;
    }

    public void GoToGameplayLevel(LevelLoadingData levelLoadingData, int sceneID)
    {
        _levelLoader.Load(levelLoadingData, sceneID);
    }

    public void GoToMainMenu()
    {
        _simpleSceneLoader.Load(MainMenuID);
    }
}
