using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : MonoBehaviour
{
    public Rigidbody2D thiefRb;
    public float speed;
    public int health;
    void FixedUpdate() 
    {
        thiefRb.velocity = Vector2.left * speed;  
    } 
}
