using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : masterPlayerController
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PerformMovement();
    }

    public override void PerformMovement()
    {
        if (Input.GetKey(KeyCode.W) && (player.velocity.y < maxSpeed))
        {
            Move(1);
        }
        else if (Input.GetKey(KeyCode.S) && (player.velocity.y > -maxSpeed))
        {
            Move(-1);
        }
        else { ApplyBrake(); }
    }
}
