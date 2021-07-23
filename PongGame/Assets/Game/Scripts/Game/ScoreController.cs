using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    private int rightPlayerScore = 0;
    private int leftPlayerScore = 0;
    public bool hasEnteredTrigger { get; private set; } = false;

    public Text leftScoreLabel;
    public Text rightScoreLabel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("RightScore"))
        {
            ++leftPlayerScore;
            leftScoreLabel.text = leftPlayerScore.ToString();
        }
        if (collision.CompareTag("LeftScore"))
        {
            ++rightPlayerScore;
            rightScoreLabel.text = rightPlayerScore.ToString();
        }

        hasEnteredTrigger = true;
    }

    public void scoreProcessed()
    {
        hasEnteredTrigger = false;
    }
}
