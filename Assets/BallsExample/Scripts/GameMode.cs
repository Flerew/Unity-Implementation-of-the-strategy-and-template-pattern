using UnityEngine;

public class GameMode : MonoBehaviour
{
    public int SelectedMode { get; private set; } // 0-all balls 1-random balls

    public void SwitchGameMode(int modeValue)
    {
        if(modeValue >= 0)
            SelectedMode = modeValue;
    }
}
