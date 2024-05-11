using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoader : ILevelLoader, ISimpleSceneLoader
{
    private ZenjectSceneLoaderWrapper _sceneLoader;

    public SceneLoader(ZenjectSceneLoaderWrapper sceneLoader)
    {
        _sceneLoader = sceneLoader;
    }

    public void Load(LevelLoadingData levelLoadingData, int sceneID)
    {
        _sceneLoader.Load(sceneID, 
        container =>
        {
            container.BindInstance(levelLoadingData).AsSingle();
        });
    }

    public void Load(int sceneID)
    {
        _sceneLoader.Load(sceneID);
    }
}
