using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleplayerAI : MonoBehaviour
{
    public GameObject theBall;
    public GameController gameController;
    public SettingsMenu settingsMenu;

    float speed;
    float lerpSpeed;
    Rigidbody2D rigidBody;

    public void Start()
    {
        OnDifficultyChange();
        rigidBody = GetComponent<Rigidbody2D>();
        settingsMenu.DifficultyChange += OnDifficultyChange;
    }

    public void FixedUpdate()
    {
        if (theBall.transform.position.y > transform.position.y)
        {
            if (rigidBody.velocity.y < 0) rigidBody.velocity = Vector2.zero;
            rigidBody.velocity = Vector2.Lerp(rigidBody.velocity, Vector2.up * speed, lerpSpeed * Time.fixedDeltaTime);

        }
        else if (theBall.transform.position.y < transform.position.y)
        {
            if (rigidBody.velocity.y > 0) rigidBody.velocity = Vector2.zero;
            rigidBody.velocity = Vector2.Lerp(rigidBody.velocity, Vector2.down * speed, lerpSpeed * Time.fixedDeltaTime);

        }
        else
        {
            //rigidBody.velocity = Vector2.Lerp(rigidBody.velocity, Vector2.zero * speed, lerpSpeed * Time.fixedDeltaTime);
        }
    }

    private void OnDifficultyChange()
    {
        switch (gameController.difficulty)
        {
            case 0:
                speed = 60f;
                lerpSpeed = 0.35f;
                break;
            case 1:
                speed = 65f;
                lerpSpeed = 0.45f;
                break;
            case 2:
                speed = 75f;
                lerpSpeed = 0.50f;
                break;
        }
    }

    private void DifficultyHasChanged()
    {
        if(settingsMenu != null)
        {
            settingsMenu.DifficultyChange -= OnDifficultyChange;
        }
    }
}
