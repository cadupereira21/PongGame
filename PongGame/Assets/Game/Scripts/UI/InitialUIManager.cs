using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InitialUIManager : MonoBehaviour
{
    public void PlayMultiplayerMode()
    {
        SceneManager.LoadScene("Multiplayer");
    }

    public void QuitGame() 
    {
        Debug.Log("Quiting!");
        Application.Quit();
    }
}
