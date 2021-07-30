using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    public GameController gameController;

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
        gameController.difficulty = difficultyIndex;
        Debug.Log(gameController.difficulty);
    }
}
