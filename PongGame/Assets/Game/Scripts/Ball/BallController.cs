using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class BallController : MonoBehaviour
{
    Rigidbody2D ball;

    [SerializeField]
    [Range(5f, 50f)]
    float maxForce = 20f;

    [SerializeField]
    [Range(0.1f, 50f)]
    float minimumForce = 19f;

    float horizontalSpeed;
    float verticalSpeed;
    float directions;

    // Start is called before the first frame update
    void Start()
    {
        ball = GetComponent<Rigidbody2D>();

        StartCoroutine(MoveRandomly());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    public IEnumerator MoveRandomly()
    {
        directions = Random.Range(0, 5);
        horizontalSpeed = Random.Range(minimumForce, maxForce);
        verticalSpeed = Random.Range(minimumForce, maxForce);

        yield return new WaitForSeconds(GameController.ballWaitingNumber);

        if (directions > 3)
        {
            ball.AddForce(new Vector2(horizontalSpeed * 10, verticalSpeed * 10));
        } else if (directions > 2)
        {
            ball.AddForce(new Vector2(-horizontalSpeed * 10, verticalSpeed * 10));
        } else if (directions > 1)
        {
            ball.AddForce(new Vector2(horizontalSpeed * 10, -verticalSpeed * 10));
        } else
        {
            ball.AddForce(new Vector2(-horizontalSpeed * 10, -verticalSpeed * 10));
        }
    }

    public void ResetBall()
    {
        StopAllCoroutines();
        this.transform.position = new Vector3(0, 0, 0);
        ball.velocity = new Vector2(0, 0);
        StartCoroutine(MoveRandomly());
    }
}
