using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameModeSwitcherButton : MonoBehaviour
{
    [SerializeField] private int _buttonGameMode;
    [SerializeField] private GameObject _gameModeObject;
    [SerializeField] private bool _isActive = false;

    private GameMode _gameMode;
    private Image _image;

    private void Awake()
    {
        _gameMode = _gameModeObject.GetComponent<GameMode>();
        _image = GetComponent<Image>();
    }

    public void OnClick()
    {
        if(_isActive == false)
        {
            GameObject[] buttons = GameObject.FindGameObjectsWithTag("GameModeButton");
            foreach(GameObject button in buttons)
            {
                if(button.TryGetComponent(out GameModeSwitcherButton component))
                {
                    component.DisableButton();
                }
            }

            SwitchGameMode();
            EnableButton();
        }
    }

    public void DisableButton()
    {
        _isActive = false;
        _image.color = Color.white;
    }

    public void SwitchGameMode()
    {
        _gameMode.SwitchGameMode(_buttonGameMode);
    }

    private void EnableButton()
    {
        _isActive = true;
        _image.color = Color.green;
    }
}
