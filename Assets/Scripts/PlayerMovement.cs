using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody2D player;
    private int speed = 3;
    
    private void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space)))
        {
            Jump();
        }
    }

    private void Jump()
    {
        player.velocity = transform.up * speed;
    }
}
