using System;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class BallsCounter : MonoBehaviour
{
    [SerializeField] private GameObject _gameModeObject;
    [SerializeField] private GameObject _victoryText;

    private int _ballsCount;
    private int _victoryBallsCount;
    private BallType _victoryBallsColor;
    private GameMode _gameMode;
    private bool isSelectVictoryColor;

    private void Awake()
    {
        _gameMode = _gameModeObject.GetComponent<GameMode>();
    }

    public void AddBall(BallType ballColor)
    {
        if (_gameMode.SelectedMode == 1 && isSelectVictoryColor == false)
        {
            SelectVictoryColor((BallType)Random.Range(0, Enum.GetValues(typeof(BallType)).Length));
        }

        if(ballColor == _victoryBallsColor && _gameMode.SelectedMode == 1)
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

        if(_gameMode.SelectedMode == 0 && _ballsCount <= 0)
        {
            _victoryText.SetActive(true);
        }
        else if(_gameMode.SelectedMode == 1 && _victoryBallsCount <= 0)
        {
            _victoryText.SetActive(true);
        }
    }

    private void SelectVictoryColor(BallType victoryColor)
    {
        _victoryBallsColor = victoryColor;
        isSelectVictoryColor = true;
    }
}
