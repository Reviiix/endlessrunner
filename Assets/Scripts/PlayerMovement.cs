using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody2D player;
    public int speed = 3;
    public AudioSource PlayerJump;
    public AudioSource PlayerDeath;
    
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
        PlayerJump.Play();
    }

    public void Death()
    {
        PlayerDeath.Play();  
    }
}
