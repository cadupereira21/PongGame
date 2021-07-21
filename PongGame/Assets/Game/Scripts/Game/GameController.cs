﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public ScoreController scoreController;
    public BallController ball;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreController.hasEnteredTrigger)
        {
            ball.ResetBall();
            scoreController.scoreProcessed();
        }
    }
}