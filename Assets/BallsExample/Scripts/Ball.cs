using UnityEngine;

public class Ball : MonoBehaviour
{
    private BallType _ballType;
    private Color _color;
    private Renderer _renderer;
    private BallsCounter _counter;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void OnDestroy()
    {
        _counter.RemoveBall(this);
    }

    public void Initialize(BallType ballType, BallsCounter ballsCounter)
    {
        _ballType = ballType;
        IdentifyColor(_ballType);
        _renderer.material.color = _color;
        _counter = ballsCounter;
        _counter.AddBall(ballType);
    }

    public BallType GetBallType()
    {
        return _ballType;
    }

    private void IdentifyColor(BallType ballType)
    {
        switch(ballType)
        {
            case BallType.Red:
                _color = Color.red;
                break;
            case BallType.Blue:
                _color = Color.blue; 
                break;
            case BallType.White: 
                _color = Color.white;
                break;
        }
    }
}
