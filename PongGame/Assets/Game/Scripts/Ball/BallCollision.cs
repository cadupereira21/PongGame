using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            FindObjectOfType<AudioManager>().Play(GameSounds.playerHit);
        }
        else if (collision.collider.CompareTag("Constraint"))
        {
            FindObjectOfType<AudioManager>().Play(GameSounds.constraintHit);
        }
    }
}