using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    [SerializeField] private List<GameObject> _removeUI;
    [SerializeField] private BallsSpawner _ballsSpawner;

    public void OnClick()
    {
        foreach (GameObject gameObject in _removeUI)
        {
            gameObject.SetActive(false);
        }

        _ballsSpawner.Spawn();
    }
}
