using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SettingsMenu : MonoBehaviour
{
    public GameController gameController;
    public event Action DifficultyChange;
    public GameObject difficultyErrorMessage;

    public void SetGraphics(int graphicsIndex)
    {
        FindObjectOfType<AudioManager>().Play(GameSounds.ButtonClick);
        QualitySettings.SetQualityLevel(graphicsIndex);
    }

    public void SetFullscreen (bool isFullscren)
    {
        FindObjectOfType<AudioManager>().Play(GameSounds.ButtonClick);
        Screen.fullScreen = isFullscren;
    }

    public void SetDifficulty(int difficultyIndex)
    {
        FindObjectOfType<AudioManager>().Play(GameSounds.ButtonClick);
        if (gameController.isSingleplayer) {
            gameController.difficulty = difficultyIndex;
            DifficultyChange.Invoke();
            Debug.Log(gameController.difficulty);
        }
        else if (gameController.isMultiplayer)
        {
            ShowErrorMessage();
        }
    }

    private void ShowErrorMessage()
    {
        FindObjectOfType<AudioManager>().Play(GameSounds.ButtonClick);
        difficultyErrorMessage.SetActive(true);
    }
}
