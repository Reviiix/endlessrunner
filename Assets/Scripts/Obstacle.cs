using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed = 5f;

    private void Update()
    {
        var newPosition = transform.position + Vector3.left * speed * Time.deltaTime;
        
        transform.position = newPosition;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        col.GetComponent<PlayerMovement>().Death();
    }
}
