using System;

public class LevelLoadingData
{
    private int _gameMode;

    public LevelLoadingData(int gameMode)
    {
        _gameMode = gameMode;
    }

    public int GameMode
    {
        get => _gameMode;
        set
        {
            if (value < 0) 
                throw new ArgumentOutOfRangeException(nameof(value));
        }
    }
}
