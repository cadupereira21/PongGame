using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleplayerAI : MonoBehaviour
{
    public GameObject theBall;

    [SerializeField] float speed = 30;
    [SerializeField] float lerpSpeed = 1f;
    Rigidbody2D rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
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
            rigidBody.velocity = Vector2.Lerp(rigidBody.velocity, Vector2.zero * speed, lerpSpeed * Time.fixedDeltaTime);
        }
    }
}
