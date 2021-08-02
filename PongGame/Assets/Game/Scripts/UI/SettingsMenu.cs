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
        QualitySettings.SetQualityLevel(graphicsIndex);
    }

    public void SetFullscreen (bool isFullscren)
    {
        Screen.fullScreen = isFullscren;
    }

    public void SetDifficulty(int difficultyIndex)
    {
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
        difficultyErrorMessage.SetActive(true);
    }
}
