﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private int minutes = 0;
    private float seconds = 0;
    [SerializeField] private float secondsLimit = 60f;

    public Text minutesLabel;
    public Text secondsLabel;

    // Update is called once per frame
    void Update()
    {
        secondsLabel.text = seconds.ToString("00");
        minutesLabel.text = minutes.ToString("00");
        seconds += Time.deltaTime;

        if(seconds > secondsLimit)
        {
            minutes++;
            seconds = 0;
        }
    }
}
