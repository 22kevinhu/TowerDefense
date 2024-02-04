using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : MonoBehaviour
{
    public Rigidbody2D thiefRb;
    public float speed;
    public int health;

    void Start()
    {
        speed = 10;
        health = 10;
    }

   void FixedUpdate() 
    {
        while (health != 0) {
            transform.position += Time.deltaTime * Vector3.left * speed;
        }

    }
}