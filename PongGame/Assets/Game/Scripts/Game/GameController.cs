using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public ScoreController scoreController;
    public BallController ball;
    public static int ballWaitingNumber = 3;
    public int difficulty { get; set; } = 0; // 0 = easy | 1 = medium | 2 = hard
    public bool isMultiplayer { get; private set; }
    public bool isSingleplayer { get; private set; }

    // Start is called before the first frame update
    public void Start()
    {
        string actualScene = SceneManager.GetActiveScene().name;
        if (actualScene.Equals("Singleplayer"))
        {
            isSingleplayer = true;
            isMultiplayer = false;
        } else if (actualScene.Equals("Multiplayer"))
        {
            isSingleplayer = false;
            isMultiplayer = true;
        }
        else
        {
            isSingleplayer = false;
            isMultiplayer = false;
        }
    }

    // Update is called once per frame
    public void Update()
    {
        if (scoreController.hasEnteredTrigger)
        {
            ball.ResetBall();
            scoreController.scoreProcessed();
        }
    }
}
