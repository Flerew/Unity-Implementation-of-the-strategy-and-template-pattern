using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using Random = UnityEngine.Random;

public class BallsCounter : MonoBehaviour
{
    [SerializeField] private GameMediator _gameMediator;

    private int _ballsCount;
    private int _victoryBallsCount;
    private BallType _victoryBallsColor;
    private bool isSelectVictoryColor;
    private LevelLoadingData _levelLoadingData;

    [Inject]
    private void Construct(LevelLoadingData loadingData)
        => _levelLoadingData = loadingData;

    public void AddBall(BallType ballColor)
    {
        if (_levelLoadingData.GameMode == 1 && isSelectVictoryColor == false)
        {
            SelectVictoryColor((BallType)Random.Range(0, Enum.GetValues(typeof(BallType)).Length));
        }

        if(ballColor == _victoryBallsColor && _levelLoadingData.GameMode == 1)
        {
            _victoryBallsCount++;
            _ballsCount++;
        }
        else
        {
            _ballsCount++;
        }
    }

    public void RemoveBall(Ball ball)
    {
        if(ball.GetBallType() == _victoryBallsColor)
        {
            _victoryBallsCount--;
        }

        _ballsCount--;

        if(_levelLoadingData.GameMode == 0 && _ballsCount <= 0)
        {
            _gameMediator.EnableVictoryUI();
        }
        else if(_levelLoadingData.GameMode == 1 && _victoryBallsCount <= 0)
        {
            _gameMediator.EnableVictoryUI();
        }
    }

    private void SelectVictoryColor(BallType victoryColor)
    {
        _victoryBallsColor = victoryColor;
        isSelectVictoryColor = true;
    }
}
