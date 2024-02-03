using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : MonoBehaviour
{
    public Rigidbody2D thiefRb;
    public float Speed;
    public int Health;

   void FixedUpdate() 
    {
        while (Health != 0) {
            transform.position += Time.deltaTime * Vector3.left * Speed;
        }

    }
}