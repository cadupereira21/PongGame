using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    private int rightPlayerScore = 0;
    private int leftPlayerScore = 0;
    public bool hasEnteredTrigger { get; private set; } = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("RightScore"))
        {
            Debug.Log("Ponto do player esquerdo!");
            leftPlayerScore++;
        }
        if (collision.CompareTag("LeftScore"))
        {
            Debug.Log("Ponto do player direito!");
            rightPlayerScore++;
        }

        hasEnteredTrigger = true;
    }

    public void scoreProcessed()
    {
        hasEnteredTrigger = false;
    }
}
