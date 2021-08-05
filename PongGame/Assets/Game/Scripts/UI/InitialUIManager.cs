using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InitialUIManager : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject controlsMenu;

    public void PlayMultiplayerMode()
    {
        FindObjectOfType<AudioManager>().Play(GameSounds.ButtonClick);
        SceneManager.LoadScene("Multiplayer");
    }

    public void PlaySingleplayerMode()
    {
        FindObjectOfType<AudioManager>().Play(GameSounds.ButtonClick);
        SceneManager.LoadScene("Singleplayer");
    }

    public void LoadControlsMenu()
    {
        FindObjectOfType<AudioManager>().Play(GameSounds.ButtonClick);
        mainMenu.SetActive(false);
        controlsMenu.SetActive(true);
    }

    public void HideControlsMenu()
    {
        FindObjectOfType<AudioManager>().Play(GameSounds.ButtonClick);
        controlsMenu.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void QuitGame() 
    {
        Debug.Log("Quiting!");
        Application.Quit();
    }
}
